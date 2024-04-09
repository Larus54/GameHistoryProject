using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameHistoryProject.Extensions.ListGame_Type;
using System.IO;
using System.Drawing.Imaging;
using OpenQA.Selenium.DevTools.V120.Page;

namespace GameHistoryProject
{
    public partial class frmSearch : Form
    {
        string tokenapi;
        string username;
        string client_id;
        int[] idgames;
        list_games current_account = new list_games();
        games selectedgames;
        string json_filepath;
        public frmSearch(string token, string username, string client_id)
        {
            InitializeComponent();
            this.tokenapi = token;
            this.username = username;
            this.client_id = client_id;

            cmbTypes.Items.Add("Giochi");
            cmbTypes.Items.Add("DLC");
            cmbTypes.Items.Add("Espansioni");
            cmbTypes.Items.Add("Bundle");
            cmbTypes.Items.Add("Espans. Standalone");
            btnMore.Enabled = false;
            cmbTypes.SelectedIndex = 0;
            json_filepath= "accounts/" + username + "/" + username + ".json";


            //loading del json
            if(File.Exists(json_filepath))
            {
                var loadedJsonString = File.ReadAllText(json_filepath);
                current_account = JsonConvert.DeserializeObject<list_games>(loadedJsonString);
                MessageBox.Show(current_account.games[0].game_name);
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //search button
        }

        private async void btnSearchGame_Click(object sender, EventArgs e)
        {
            //search button


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("Client-ID", client_id);
                client.DefaultRequestHeaders.Add("Authorization", tokenapi);

                string data = "search \"" + txtsearch.Text + "\"; " + "fields name; limit 500; where category = " + cmbTypes.SelectedIndex + ";";

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                var response = client.PostAsync("https://api.igdb.com/v4/games", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    int i = 0;
                    lstgames.Items.Clear();
                    var responsecontent = await response.Content.ReadAsStringAsync();
                    JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(responsecontent);

                    idgames = new int[jsonresponse.Count];
                    foreach (JObject item in jsonresponse)
                    {

                        lstgames.Items.Add(item["name"].Value<string>());
                        idgames[i] = item["id"].Value<int>();
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void lstgames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string photos_filepath = "accounts/" + username + "/photos/" + idgames[lstgames.SelectedIndex].ToString() + ".jpg";
            //selectedindex
            selectedgames = new games();
            //title
            if (lstgames.SelectedIndex != -1)
            {
                lbltitlegame.Text = lstgames.SelectedItem.ToString();
                selectedgames.game_name = lstgames.SelectedItem.ToString();
                selectedgames.game_id = idgames[lstgames.SelectedIndex];
            }


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("Client-ID", client_id);
                client.DefaultRequestHeaders.Add("Authorization", tokenapi);


                //developer
                string data = "fields name; where developed = [" + idgames[lstgames.SelectedIndex] + "];";
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                var response = client.PostAsync("https://api.igdb.com/v4/companies", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responsecontent = await response.Content.ReadAsStringAsync();

                    JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(responsecontent);
                    if(jsonresponse.Count > 0)
                    {
                        lbldeveloper.Text = jsonresponse[0]["name"].Value<string>();
                    }
                    else
                    {
                        lbldeveloper.Text = "Developer sconosciuto"; 
                    }
                    selectedgames.game_developer = lbldeveloper.Text;
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }


                //description
                string data_summary = "fields summary; where id = " + idgames[lstgames.SelectedIndex] + ";";
                StringContent content_summary = new StringContent(data_summary, Encoding.UTF8, "application/json");

                var response_summary = client.PostAsync("https://api.igdb.com/v4/games", content_summary).Result;

                if (response_summary.IsSuccessStatusCode)
                {
                    var jsonresponse_content = await response_summary.Content.ReadAsStringAsync();

                    JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(jsonresponse_content);
                    if (jsonresponse.Count > 0)
                    {
                        txtdescription.Text = jsonresponse[0]["summary"].Value<string>();
                    }
                    else
                    {
                        txtdescription.Text = "Nessuna descrizione possibile";
                    }
                    selectedgames.game_description = txtdescription.Text;
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }


                //cover
                    string data_cover = "fields *; where game = " + idgames[lstgames.SelectedIndex] + ";";
                    StringContent content_cover = new StringContent(data_cover, Encoding.UTF8, "application/json");

                    var response_cover = client.PostAsync("https://api.igdb.com/v4/covers", content_cover).Result;

                    if (response_cover.IsSuccessStatusCode)
                    {
                        var jsonString = await response_cover.Content.ReadAsStringAsync();
                        JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(jsonString);

                        if (jsonresponse.Count > 0)
                        {
                            var cover = jsonresponse[0]["image_id"].Value<string>() + ".jpg";
                            string linkcover = "https://images.igdb.com/igdb/image/upload/t_cover_big/" + cover;

                            piccover.Load(linkcover);
                        }

                    }
                    else
                    {
                        MessageBox.Show(response.StatusCode.ToString());
                    }
                

                btnMore.Enabled = true;
                btnMore.Image = GameHistoryProject.Properties.Resources.more;
                btnMore.FlatAppearance.BorderSize = 1;
                btnMore.Text = "Info aggiuntive";

                btnAdd.Enabled = true;
                btnAdd.Text = "Aggiungi";

            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(json_filepath);
            string photos_filepath = "accounts/" + username + "/photos/" + idgames[lstgames.SelectedIndex].ToString() + ".jpg";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            
            piccover.Image.Save(photos_filepath);
            selectedgames.game_photo_path = photos_filepath;
            if(current_account == null)
            {
                current_account = new list_games();
                current_account.games = new List<games>
                {
                    selectedgames
                };
            }
            else
                current_account.games.Add(selectedgames);

            string jsonString = JsonConvert.SerializeObject(current_account);
            File.WriteAllText(json_filepath, jsonString);

        }
      
    }
}
