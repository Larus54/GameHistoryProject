using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Net.Sockets;
using System.IO;
using OpenQA.Selenium.Interactions;
using GameHistoryProject.retexturing;

namespace GameHistoryProject
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            //Google Profile
            string profilechrome = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            profilechrome += "\\appdata\\Local\\Google\\Chrome\\User Data";
            string[] files = Directory.GetFiles(profilechrome, "*.ico", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                string profile = Path.GetDirectoryName(files[i]);
                string[] temp = profile.Split('\\');
                if (!temp[temp.Length - 1].ToLower().Equals("default"))
                    cmbProfile.Items.Add(temp[temp.Length-1]);
            }


            if(!cmbProfile.Items.Count.Equals(0))
                cmbProfile.SelectedIndex = 1;


            //File Login
            if(File.Exists("info.txt"))
            {
                string data = File.ReadAllText("info.txt");
                string[] datas = data.Split(' ');
                txt_username.Text = datas[0];
                txtclientid.Text = datas[1];

                chbremember.Checked = true;
                chbremember.Enabled = true;
            }
        }



        /// <summary>
        /// All Login process
        /// </summary>
        /// <param name="sender">Form login</param>
        /// <param name="e">parameter event args</param>
       private async void btnlogin_Click(object sender, EventArgs e)
       {
            //Materiale per il login
            string redirect = "https://larus54.github.io/login/";
            string url = "https://id.twitch.tv/oauth2/authorize?client_id="+txtclientid.Text+"&redirect_uri="+redirect+"&response_type=token";
            int token = 0;

            //profilechrome
            string profilechrome = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            profilechrome += "\\appdata\\Local\\Google\\Chrome\\User Data";

            //client id obbligatorio
            if (txtclientid.Text.Length == 0)
            {
               MessageBox.Show("Manca il client_id, leggi la guida per riuscire a trovarlo.");
               return;
            }

            //username e password obbligatori
            if(txt_username.Text.Length == 0)
            {
                MessageBox.Show("Manca Username, inseriscilo");
                return;

            }

            if(txtpassword.Text.Length == 0)
            {
                MessageBox.Show("Manca la password del profilo");
                return;
            }


            //Setting chromedriver
            ChromeOptions options = new ChromeOptions();
                
            //options.AddArgument("--headless");
            options.AddArgument("user-data-dir=" + profilechrome);
            options.AddArgument("profile-directory="+cmbProfile.SelectedItem.ToString());
               
            //Setting chromeservice
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;


            IWebDriver driver = new ChromeDriver(chromeDriverService,options);
            driver.Navigate().GoToUrl(url);
            
            //Remember Me
            if(chbremember.Checked)
            {
                string data = txt_username.Text + " " + txtclientid.Text;
                File.WriteAllText("info.txt", data);
            }

            try
            {

                //gia autorizzato manca token
                if(driver.Url.StartsWith(redirect))
                {
                    IWebElement Token = driver.FindElement(By.Id("access_token"));
                    string access_token = Token.Text;
                    string[] access_token_stripped = access_token.Split(' ');
                    string access_token_finished = access_token_stripped[1];
                    await Task.Delay(5000);
                    if (Token != null)
                    {
                        frmmain frmmain = new frmmain(access_token_finished, txt_username.Text, txtclientid.Text);
                        this.Hide();
                        driver.Close();
                        frmmain.ShowDialog();
                        return;
                    }
                }

                //Se si cambia account twitch o google profile
                if (File.Exists("token.txt"))
                {
                    string content = File.ReadAllText("token.txt");

                    string[] lines = content.Split('\n');
                    //USERNAME CAMBIATO
                    if (txt_username.Text.ToLower() != lines[1].ToLower())
                    {
                        //re-login
                        File.Delete("token.txt");
                    }
                    else
                    {
                        if (driver.Url.StartsWith(redirect))
                        {
                            IWebElement Token = driver.FindElement(By.Id("access_token"));                                
                            string access_token = Token.Text;
                            string[] access_token_stripped = access_token.Split(' ');
                            string access_token_finished = access_token_stripped[1];
                          
                            if (Token != null)
                            {
                                frmmain frmmain = new frmmain(access_token_finished,txt_username.Text,txtclientid.Text);
                                this.Hide();
                                driver.Close();
                                frmmain.ShowDialog();
                                return;
                            }
                        }
                    }
                    //PROFILE CHROME CAMBIATO
                    if (cmbProfile.SelectedText.Equals(lines[2]))
                    {
                        //re-login
                        File.Delete("token.txt");
                    }
                    else
                    {
                        if (driver.Url.StartsWith(redirect))
                        {
                           IWebElement Token = driver.FindElement(By.Id("access_token"));
                           string access_token = Token.Text;
                           string[] access_token_stripped = access_token.Split(' ');
                           string access_token_finished = access_token_stripped[1];
                           if (Token != null)
                           {
                              frmmain frmmain = new frmmain(access_token_finished, txt_username.Text, txtclientid.Text);
                              this.Hide();
                              driver.Close();
                              frmmain.ShowDialog();
                              return;
                           }
                        }
                    }
                }
                

                //Gia loggato ma non autorizzato, serve autorizzazione
                if(File.Exists("token.txt"))
                {
                    IWebElement username = driver.FindElement(By.XPath("//button[@class='user-info__username']"));
                    //login gia effettuato ma serve autorizzare l'accesso al token
                    await Task.Delay(5000);
                    IWebElement authorizebutton = driver.FindElement(By.XPath("//button[@class='js-authorize-text']"));
                    authorizebutton.Click();

                    //attesa
                    await Task.Delay(5000);

                    //prendere il token dal github
                    IWebElement accesstoken = driver.FindElement(By.Id("access_token"));
                    string access_token = accesstoken.Text;

                    frmmain frmmain = new frmmain(access_token, txt_username.Text, txtclientid.Text);
                    this.Hide();
                    driver.Quit();
                    frmmain.ShowDialog();
                    //chiudere il web browser
                    driver.Quit();
                }

                //Non loggato e non autorizzato, serve connessione completa
                //1. username
                IWebElement usernamefield = driver.FindElement(By.Id("login-username"));
                if (usernamefield != null)
                {
                    usernamefield.SendKeys(txt_username.Text);
                }
                //2. password
                IWebElement passwordfield = driver.FindElement(By.Id("password-input"));
                if (passwordfield != null)
                {
                    passwordfield.SendKeys(txtpassword.Text);
                }


                //3. access button
                IWebElement buttonlogin = driver.FindElement(By.XPath("//button[@class ='ScCoreButton-sc-ocjdkq-0 ScCoreButtonPrimary-sc-ocjdkq-1 ccqkQH gmCwLG']"));
                buttonlogin.Click();

                //4. richiesta del token
                if (token == 0)
                {
                    frmtoken tokenpass = new frmtoken();
                    if (tokenpass.ShowDialog(this) == DialogResult.OK)
                    {
                        //5. immettere text del token app
                        string texttoken = tokenpass.token;
                        IWebElement tokeninput = driver.FindElement(By.Id("authenticator-token-input"));
                        if (tokeninput != null)
                        {
                            tokeninput.SendKeys(texttoken);
                        }

                        //6. cliccare conferma del token
                        IWebElement buttontoken = driver.FindElement(By.XPath("//button[@class='ScCoreButton-sc-ocjdkq-0 ScCoreButtonPrimary-sc-ocjdkq-1 bTXTVH gmCwLG']"));
                        buttontoken.Click();
                            
                        //7. autorizzazione
                        if(driver.Url.StartsWith(redirect))
                        {
                            //8. token ottenuto
                            await Task.Delay(10000);
                            IWebElement accesstoken = driver.FindElement(By.Id("access_token"));
                            string access_token = accesstoken.Text;
                            string[] access_token_stripped = access_token.Split(' ');
                            string access_token_finished = access_token_stripped[1] + "\n" + txt_username.Text + '\n' + cmbProfile.Text;
                            File.WriteAllText("token.txt", access_token);

                            frmmain frmmain = new frmmain(access_token, txt_username.Text, txtclientid.Text);
                            this.Hide();
                            driver.Quit();
                            frmmain.ShowDialog();
                        }
                        else
                        {
                            await Task.Delay(5000);
                            IWebElement authorizebutton = driver.FindElement(By.XPath("//button[@class='button button--large js-authorize']"));
                            authorizebutton.Click();

                            //8. token ottenuto
                            await Task.Delay(10000);
                            IWebElement accesstoken = driver.FindElement(By.Id("access_token"));
                            string access_token = accesstoken.Text;
                            string[] access_token_stripped = access_token.Split(' ');
                            string access_token_finished = access_token_stripped[1] + "\n" + txt_username.Text + '\n' + cmbProfile.Text;
                            File.WriteAllText("token.txt", access_token);

                            frmmain frmmain = new frmmain(access_token, txt_username.Text, txtclientid.Text);
                            this.Hide();
                            driver.Quit();
                            frmmain.ShowDialog();
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (WebDriverException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            //TODO: Cambio di lingua
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Info
        }
    }
}