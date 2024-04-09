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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameHistoryProject
{
    public partial class frmBak : Form
    {
        public frmBak(string username)
        {
          
            list_games current_account = null;
            string json_filepath = "accounts/" + username + "/" + username + ".json";

            InitializeComponent();
            if (File.Exists(json_filepath))
            {
                var loadedJsonString = File.ReadAllText(json_filepath);
                current_account = JsonConvert.DeserializeObject<list_games>(loadedJsonString);
            }

            for(int i = 0; i < current_account.games.Count; i++) {

                lstgames.Items.Add(current_account.games[i].game_name); 

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length >= 3)
            {


            }
        }
    }
}
