using GameHistoryProject.Extensions.ListGame_Type;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameHistoryProject
{
    public partial class frmAddcategory : Form
    {
        string username;
        string idselectedgame;
        list_games current_account = null;
        string json_filepath;
        private Point mouseDownLocation;

        public frmAddcategory(string username, string idselectedgame)
        {
            this.username = username;
            this.idselectedgame = idselectedgame;
            json_filepath = "accounts/" + this.username + "/" + this.username + ".json";
            InitializeComponent();
            cmbCategories.Items.Add("----");
            if (File.Exists(json_filepath))
            {
                var loadedJsonString = File.ReadAllText(json_filepath);
                current_account = JsonConvert.DeserializeObject<list_games>(loadedJsonString);

                //sorting 
                current_account.games.Sort((p1, p2) => p1.game_name.CompareTo(p2.game_name));
                for(int i = 0; i<current_account.games.Count; i++)
                {
                    cmbCategories.Items.Add(current_account.games[i].status_category);
                }

                checkduplicate();
                
                cmbCategories.SelectedIndex = 0;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void frmAddcategory_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string selected = cmbCategories.SelectedItem.ToString();
            if (selected.Equals("----"))
            {
                if (txtcatname.Text.Length == 0)
                {
                    MessageBox.Show("Inserisci il nome della catagoria", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < current_account.games.Count; i++)
                {
                    if (current_account.games[i].game_id.ToString() == idselectedgame)
                    {
                        current_account.games[i].status_category = txtcatname.Text;
                        string jsonString = JsonConvert.SerializeObject(current_account);
                        File.WriteAllText(json_filepath, jsonString);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                for (int i = 0; i < current_account.games.Count; i++)
                {
                    if (current_account.games[i].game_id.ToString() == idselectedgame)
                    {
                        current_account.games[i].status_category = selected;
                        string jsonString = JsonConvert.SerializeObject(current_account);
                        File.WriteAllText(json_filepath, jsonString);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void checkduplicate()
        {
            List<string> uniqueItems = new List<string>();

            // Iterate through the ComboBox items
            foreach (string item in cmbCategories.Items)
            {
                // Check if the item is already present in uniqueItems
                if (!uniqueItems.Contains(item))
                {
                    // Add the unique item to the collection
                    uniqueItems.Add(item);
                }
            }

            // Clear the ComboBox and add unique items
            cmbCategories.Items.Clear();
            cmbCategories.Items.AddRange(uniqueItems.ToArray());
        }

        private void pnlTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }
        private void pnlTopbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(
                    this.Location.X + (e.Location.X - mouseDownLocation.X),
                    this.Location.Y + (e.Location.Y - mouseDownLocation.Y)
                 );

                newLocation.X = Math.Max(0, newLocation.X);
                newLocation.Y = Math.Max(0, newLocation.Y);


                this.Location = newLocation;


            }
        }
    }
}
