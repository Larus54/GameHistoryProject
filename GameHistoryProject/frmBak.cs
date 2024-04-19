using GameHistoryProject.Extensions;
using GameHistoryProject.Extensions.ListGame_Type;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameHistoryProject
{
    public partial class frmBak : Form
    {

        private ContextMenuStrip menuStripLst;
        string username;
        list_games current_account = null;
        string json_filepath;
        public frmBak(string username)
        {
            this.username = username;
            json_filepath = "accounts/" + this.username + "/" + this.username + ".json";
            InitializeComponent();
            if (File.Exists(json_filepath))
            {
                var loadedJsonString = File.ReadAllText(json_filepath);
                current_account = JsonConvert.DeserializeObject<list_games>(loadedJsonString);

                //sorting 
                current_account.games.Sort((p1,p2) => p1.game_name.CompareTo(p2.game_name));

                for (int i = 0; i < current_account.games.Count; i++)
                {

                    lstgames.Items.Add(current_account.games[i].game_name);
                    cmbTypes.Items.Add(current_account.games[i].status_category);
                }

                checkduplicate();

                cmbTypes.SelectedIndex = 0;
                this.menuStripLst = new ContextMenuStrip();
                this.menuStripLst.Items.Add("Visualizza dettagli", null, VisualizzaDettagli_Click);
                this.menuStripLst.Items.Add("Aggiungi ad una categoria", null, CreazioneCategoria_Click);
            }

            lstgames.MouseDown += new MouseEventHandler(listBox_MouseDown);
        }
        /// <summary>
        /// Metodo inserito su tutti gli elementi della combobox, per vedere i dettagli del gioco selezionato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisualizzaDettagli_Click(object sender, EventArgs e)
        {
            string elemento = lstgames.SelectedItem.ToString();
            MessageBox.Show("Elemento" + elemento);
        }

        /// <summary>
        /// Metodo messo su tutti gli elementi della combobox, per creare delle categorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreazioneCategoria_Click(object sender, EventArgs e)    
        {
            //creazione della categoria
            games temp = getInfo(lstgames.SelectedItem.ToString());
            frmAddcategory addcategory = new frmAddcategory(username, temp.game_id.ToString());
            addcategory.StartPosition = FormStartPosition.CenterScreen;
            if (addcategory.ShowDialog() == DialogResult.OK)
            {
                //aggiornamento status
                lblupdate.Text = "Categoria aggiunta con successo!";
                lblstatussuccess.Text = "✔";
                lblstatussuccess.ForeColor = Color.Green;

                deserializeList();
                cmbTypes.Items.Clear();
                for (int i = 0; i < current_account.games.Count; i++)
                {
                    cmbTypes.Items.Add(current_account.games[i].status_category);
                }
                checkduplicate();
                cmbTypes.SelectedIndex = 0;
            }
            else
            {
                lblupdate.Text = "Categoria non aggiunta!";
                lblstatussuccess.Text = "❌";
                lblstatussuccess.ForeColor = Color.Red;
            }
        }

        private void frmBak_Load(object sender, EventArgs e)
        {
            //creazioni delle picture box per i giochi
            string folderPath = "accounts/" + username + "/photos";
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                FileInfo[] fileInfo = directoryInfo.GetFiles();
                int x = 30;
                int y = 40;
                int i = 0;

                foreach (string file in files)
                {
                    if(IsImageFile(file))
                    {
                        //creazione picturebox automatiche e dinamiche
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(x, y);
                        pictureBox.Size = new Size(122, 185);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        pictureBox.Image = Image.FromFile(file);
                        pictureBox.Click += new EventHandler(PictureBox_Click);
                        pictureBox.Tag = fileInfo[i].Name;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        pnlInfo.Controls.Add(pictureBox);

                        x += 180;
                        if(x + 120 > pnlInfo.Width)
                        {
                            x = 30;
                            y += 202;
                        }
                        i++;
                    }
                }
            }
        }
    
        /// <summary>
        /// Cotnrollo per vedere se è un immagine con un formato consentito
        /// </summary>
        /// <param name="filePath">percorso dove trovare i file immagine</param>
        /// <returns>Ritorna true se è un immagine con un formato consentito, false altrimenti</returns>
        static bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Aggiornamento del file json in caso di aggiunte categorie o altre modifiche
        /// </summary>
        private void deserializeList()
        {
            if (File.Exists(json_filepath))
            {
                var loadedJsonString = File.ReadAllText(json_filepath);
                current_account = JsonConvert.DeserializeObject<list_games>(loadedJsonString);

                //sorting 
                current_account.games.Sort((p1, p2) => p1.game_name.CompareTo(p2.game_name));
            }
        }
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(lstgames.SelectedIndex != -1)
                {
                    //cambio location
                    int x = e.Location.X;
                    int y = e.Location.Y + 78;
                    Point point = new Point(x, y);
                    this.menuStripLst.Show(this, point);
                }
            }
        }

        /// <summary>
        /// Visualizzazione delle informazioni del gioco cliccato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            string id = picture.Tag.ToString();

        }

        /// <summary>
        /// Controlla se sono presenti duplicati di categoria all'interno della combobox
        /// </summary>
        private void checkduplicate()
        {
            List<string> uniqueItems = new List<string>();

            // Iterate through the ComboBox items
            foreach (string item in cmbTypes.Items)
            {
                // Check if the item is already present in uniqueItems
                if (!uniqueItems.Contains(item))
                {
                    // Add the unique item to the collection
                    uniqueItems.Add(item);
                }
            }

            // Clear the ComboBox and add unique items
            cmbTypes.Items.Clear();
            cmbTypes.Items.AddRange(uniqueItems.ToArray());
        }

        /// <summary>
        /// Metodo per ottenere le informazioni di un gioco a partire dal suo nome
        /// </summary>
        /// <param name="name">Nome del gioco passato in ingresso</param>
        /// <returns>Tutte le informazioni relative al gioco all'interno del profilo twitch</returns>
        private games getInfo(string name)
        {
            for(int i = 0; i<current_account.games.Count; i++)
            {
                if (current_account.games[i].game_name.Equals(name))
                {
                    return current_account.games[i];
                }
            }

            return null;
        }
        private void lstgames_DrawItem(object sender, DrawItemEventArgs e)
        {   
        }
    }
}
