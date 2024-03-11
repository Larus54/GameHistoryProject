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


namespace GameHistoryProject
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            txtclientid.Text = "fc7b68cz256hwvehp5ozz746ddwzyp";

            txt_username.Text = "Larus_54";
            txtpassword.Text = "63624294AM";

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

            cmbProfile.SelectedIndex = 0;
        }
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


            //Setting chromedriver
            ChromeOptions options = new ChromeOptions();
                
            //options.AddArgument("--headless");
            options.AddArgument("--silent");
            options.AddArgument("user-data-dir=" + profilechrome);
            options.AddArgument("profile-directory="+cmbProfile.SelectedItem.ToString());
               
            //Setting chromeservice
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;


            IWebDriver driver = new ChromeDriver(chromeDriverService, options);
            driver.Navigate().GoToUrl(url);

            try
            {
                //Gia loggato e autorizzato - link gia nel git, prendere solo il token
                if(driver.Url.StartsWith(redirect))
                {
                    {
                        IWebElement Token = driver.FindElement(By.Id("access_token"));
                        if (Token != null)
                        {
                            this.Hide();
                            frmmain frmmain = new frmmain(Token.Text, txt_username.Text);
                            driver.Close();
                            frmmain.ShowDialog();
                            return;
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

                    frmmain frmmain = new frmmain(access_token, txt_username.Text);
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
                        await Task.Delay(5000);
                        IWebElement authorizebutton = driver.FindElement(By.XPath("//button[@class='button button--large js-authorize']"));
                        authorizebutton.Click();


                        //8. token ottenuto
                        IWebElement accesstoken = driver.FindElement(By.Id("access_token"));
                        string access_token = accesstoken.Text;
                        File.WriteAllText("token.txt", access_token);

                        frmmain frmmain = new frmmain(access_token, txt_username.Text);
                        frmmain.ShowDialog();
                        this.Close();
                        driver.Quit();
                    }
                }
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

        private void menu_info_Click(object sender, EventArgs e)
        {
            //TODO: Come ottenere il client id senza sapere il client secret.
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            //TODO: Cambio di lingua
        }
    }
}