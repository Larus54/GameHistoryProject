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
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            string url = "https://id.twitch.tv/oauth2/authorize?client_id=" + txtclientid.Text + "&redirect_uri=https://barrycarlyon.github.io/twitch_misc/authentication/implicit_auth/&response_type=token";
            if (txtclientid.Text.Length == 0)
            {
                MessageBox.Show("Manca il client_id, leggi la guida per riuscire a trovarlo.");
                return;
            }


            //Setting chromedriver
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--silent");
            int token = 0;

            //Setting chromeservice
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;


            IWebDriver driver = new ChromeDriver(chromeDriverService, options);
            driver.Navigate().GoToUrl(url);

            try
            {
                IWebElement usernamefield = driver.FindElement(By.Id("login-username"));
                if (usernamefield != null)
                {
                    usernamefield.SendKeys(txt_username.Text);
                }

                IWebElement passwordfield = driver.FindElement(By.Id("password-input"));
                if (passwordfield != null)
                {
                    passwordfield.SendKeys(txtpassword.Text);
                }

                IWebElement buttonlogin = driver.FindElement(By.XPath("//button[@class ='ScCoreButton-sc-ocjdkq-0 ScCoreButtonPrimary-sc-ocjdkq-1 ccqkQH gmCwLG']"));
                buttonlogin.Click();

                if (token == 0)
                {
                    frmtoken tokenpass = new frmtoken();
                    if (tokenpass.ShowDialog(this) == DialogResult.OK)
                    {
                        string texttoken = tokenpass.token;
                        IWebElement tokeninput = driver.FindElement(By.Id("authenticator-token-input"));
                        if (tokeninput != null)
                        {
                            tokeninput.SendKeys(texttoken);
                        }

                        IWebElement buttontoken = driver.FindElement(By.XPath("//button[@class='Layout-sc-1xcs6mc-0 fPOYzN']"));
                        buttontoken.Click();


                        if (driver.Url.StartsWith("https://barrycarlyon.github.io/twitch_misc/authentication/implicit_auth/"))
                        {
                            string username=driver.FindElement(By.Id(""))
                        }
                    }



                    driver.Quit();
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
    }
}
