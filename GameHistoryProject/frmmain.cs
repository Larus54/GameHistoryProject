using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHistoryProject
{
    public partial class frmmain : Form
    {
        private string tokenapi;
        private string username;
        private string client_id;
        private int[] idgames;

        public frmmain(string tokenapi, string username, string client_id)
        {
            InitializeComponent();
            this.tokenapi = tokenapi;
            this.username = username;
            this.client_id = client_id;
            lblusername.Text += "" + this.username + " - " + this.tokenapi;
            lblstatus.Text = "online";
            lblstatus.ForeColor = Color.Green;
            this.tokenapi = "Bearer " + tokenapi;
            cmbTypes.Items.Add("Giochi");
            cmbTypes.Items.Add("DLC");
            cmbTypes.Items.Add("Espansione");
            cmbTypes.Items.Add("Espa. Standalone");
            cmbTypes.SelectedIndex = 0;
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Client-ID", client_id);
            client.DefaultRequestHeaders.Add("Authorization", tokenapi);

            string data = "search \""+ txtsearch.Text + "\"; " + "fields name; limit 500; where category = " + cmbTypes.SelectedIndex + ";";

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://api.igdb.com/v4/games", content).Result;

            if(response.IsSuccessStatusCode)
            {
                int i = 0;
                lstgames.Items.Clear();
                var responsecontent =await response.Content.ReadAsStringAsync();
                JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(responsecontent);

                idgames = new int[jsonresponse.Count];
                foreach ( JObject item in jsonresponse)
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

        private async void lstgames_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //title
            lbltitlegame.Text = lstgames.SelectedItem.ToString();

            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Client-ID", client_id);
            client.DefaultRequestHeaders.Add("Authorization", tokenapi);


            //developer
            string data = "fields name; where developed = [" + idgames[lstgames.SelectedIndex] + "];";
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://api.igdb.com/v4/companies", content).Result;

            if(response.IsSuccessStatusCode)
            {
                var responsecontent = await response.Content.ReadAsStringAsync();

                JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(responsecontent);
                lbldeveloper.Text = jsonresponse[0]["name"].Value<string>();
            }    
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
            }

            
            //description
            string data_summary = "fields summary; where id = " + idgames[lstgames.SelectedIndex] + ";";
            StringContent content_summary = new StringContent(data_summary, Encoding.UTF8, "application/json");

            var response_summary = client.PostAsync("https://api.igdb.com/v4/games", content_summary).Result;

            if(response_summary.IsSuccessStatusCode)
            {
                var jsonresponse_contentt = await response_summary.Content.ReadAsStringAsync();

                JArray jsonresponse = JsonConvert.DeserializeObject<JArray>(jsonresponse_contentt);
                if (jsonresponse.HasValues)
                {
                    txtdescription.Text = jsonresponse[0]["summary"].Value<string>();
                }
            }
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
            }
        }
    }
}
