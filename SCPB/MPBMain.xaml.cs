/*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
  Soundcloud Penetrator v0.0.2alpha
■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

▲ LICENSE MANAGEMENT
» 
»
»

▲ CURRENT BUGS
» Exception Thrown if accountlist or songlist empty
» License excepts every HASH? MAY BE NOT? Hmmmmmmm
»
»


◙◙◙◙◙◙«¶«¼╚Ìª,ƒ!┴Ì¶A ³▬┼N▬Ê▲▓ÿÀ◙M◙◙◙◙◙◙◙AF◄®┴æ|I▓Ñì
○+´6╝Èß☻»o╠○å ☺lÕ®;Od┤ıÁ+4▓▓░▒»┤│▓▓º╣$╔Ñ%Ø°×AÞ‗■!ÈµÕí
◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙◙
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using CefSharp;
using MahApps.Metro.Controls;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Reflection;
using Portable.Licensing;
using Portable.Licensing.Validation;


namespace MPB
{
    public partial class MainWindow : MetroWindow
    {

        #region //fields of sorrow
        int automatedPlays = 0;
        int maxPlaysNumber;
        string defaultSongUrl = "https://soundcloud.com";
        int timebetweenPlays = 10000;

        //Proxy Fucks givin
        string currentproxyaddress;

        //Proxy List
        List<string> proxylist = new List<string>();
        string proxyListTxt = "proxylist.txt";

        //Account List
        List<string> accountList = new List<string>();
        string currentusername;
        string currentpassword;

        //Account DataGrid 
        //Pfad noch dynamisch anpassen
        string accountDataXml = "accountlist.xml";
        DataSet dataSet = new DataSet();
        DataView accountdataView = new DataView();

        //Additional Songs
        string songsDataXml = "songs.xml";
        DataSet songSet = new DataSet();
        DataView songSetView = new DataView();

        //Automation 
        bool automationrunning = false;
        //string selectedSong;

        //Auto Follow Bot
        int maxFollowAccounts = 100;
        int followedAccountsCount = 0;

        //Like Helifopter
        int maxLikes = 10;
        int likedSongsCount = 0;

        //Repost-o-mat Settings
        int maxreposts = 10;
        int repostedCount = 0;

        //Async Task Cancellation
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        // Use when debugging the actual SubProcess, to make breakpoints etc. inside that project work.
        private static readonly bool DebuggingSubProcess = Debugger.IsAttached;
        private static string PluginInformation = "";

        //Random Number Generator
        private static Random random = new Random();
        private static Random rnd = new Random(DateTime.Now.Millisecond);
        public const string Alphabet ="0123";
        public static string RandomString(int Size)
        {
            char[] chars = new char[Size];
            for (int i = 0; i < Size; i++)
            {
                chars[i] = Alphabet[random.Next(Alphabet.Length)];
            }
            return new string(chars);
        }

        int randomnumber1 = 150;
        int randomnumber2 = 350;


        //Licensing
        private License ulicense;
        private string publicKey;

        bool licenseValid;


        //New Instance
        string newInstance = "Soundcloud Penetrator.exe";

        #endregion

        #region //Java Java! Put your script up in the air! - DOM LOADED
        public class RenderProcessMessageHandler : IRenderProcessMessageHandler
        {          

            void IRenderProcessMessageHandler.OnFocusedNodeChanged(IWebBrowser browserControl, IBrowser browser, IFrame frame, IDomNode node)
            {
                var message = node == null ? "lost focus" : node.ToString();

                Trace.WriteLine("OnFocusedNodeChanged() - " + message);
            }

            void IRenderProcessMessageHandler.OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
            {
                //const string script = "document.addEventListener('DOMContentLoaded', function(){ alert('DomLoaded'); });";

                //frame.ExecuteJavaScriptAsync(script);
                Trace.WriteLine("DOM is loaded");
            }

        }
        #endregion

        #region //CefSharp Init Settings

        public static void startBrowser()
        {
            // Specify Global Settings and Command Line Arguments
            var settings = new CefSettings();

            //Multithread
            settings.MultiThreadedMessageLoop = true;

            //settings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 8_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12B411 Safari/600.1.4";
            //settings.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; Pixel C Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/52.0.2743.98 Safari/537.36";
            //settings.UserAgent = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";


            settings.CachePath = "cache";
            settings.RemoteDebuggingPort = 8080;
            settings.CommandLineArgsDisabled = false;
            settings.LogSeverity = LogSeverity.Verbose;
            settings.PersistSessionCookies = true;
            


            CefSharp.Cef.Initialize(settings);
            Trace.WriteLine("SETTINGS LOADED");



        } 
        #endregion

        #region //Mayne, sip dat shit. MAINWINDOW

        public MainWindow()
        {
            startBrowser();

            InitializeComponent();

            //
            var mngr = Cef.GetGlobalCookieManager();
            Cookie Ac = new Cookie();
            Ac.HttpOnly = true;
            Ac.Name = ".ASPXAUTH";
            Ac.Value = "";
            mngr.SetCookieAsync(defaultSongUrl.ToString(), Ac);

            //Javascript funzt Handler
            Browser.RenderProcessMessageHandler = new RenderProcessMessageHandler();

            //Soundcloud Visbility
            soundcloudView.Visibility = Visibility.Visible;

            //Settings Visbility
            settingsView.Visibility = Visibility.Collapsed;

            //Check if proxylist file exists
            using (StreamWriter w = File.AppendText("proxylist.txt"))

            //Check if accountlist file exists 
            using (StreamWriter u = File.AppendText("accountlist.xml"))

            //Check if additional song file exists
            using (StreamWriter x = File.AppendText("songs.xml"))

            //Check if License file exists
            using (StreamWriter licenseFile = File.AppendText("license.txt"))
            
                //Browser Requestcontext start
                Browser.RequestContext = new RequestContext(new RequestContextSettings()
                {
                    CachePath = System.IO.Directory.GetCurrentDirectory() + @"\Cache\Cache" + DateTime.Now.ToLongTimeString()
                });

            //Default Soundcloud Song URL
            Browser.Address = defaultSongUrl;

            //Move default URL to textbox
            txtBox_songUrl.Text = defaultSongUrl;


            //default time between plays is set
            tbPlays.Text = Convert.ToString(timebetweenPlays / 1000);

            //Counter for generated plays is set
            genPlaysNumber.Content = automatedPlays;

            //load proxy liste :D
            loadProxyList();

            //Load Accountlist
            loadAccountsDataGrid();

            //Load additional Songs
            loadSoundCloudSongs();
            
            //Focus on webbrowser possible
            Browser.Focusable = true;

            //Max. Accounts for Followbot
            maxFollowAccountsTxtBox.Text = Convert.ToString(maxFollowAccounts);
            followedAccountsL.Content = followedAccountsCount;

            // ♥ Helicoper Max Likes bla
            maxLikesTxtBox.Text = Convert.ToString(maxLikes);
            likedLabel.Content = likedSongsCount;

            // Repost-o-mat 
            maxRepostsTxt.Text = Convert.ToString(maxreposts);
            repostsLabel.Content = repostedCount;

            //Menu Handler
            Browser.MenuHandler = new MenuHandler();

            //Mainframe finished loading
            Browser.FrameLoadEnd += (sender, args) =>
            {
                //Wait for the MainFrame to finish loading
                if (args.Frame.IsMain)
                {
                    //args.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");

                    

                    Trace.WriteLine("MainFrame finished loading");
                }
            };


            // Load the License
            loadLicense();

            // Validate License on Start
            validateLicenseOnStart();

            // Validation Shutdown
            if (licenseValid == false)
            {
                soundcloudView.Visibility = Visibility.Hidden;
                settingsView.Visibility = Visibility.Visible;
                soundcloudViewButton.IsEnabled = false;
            }


        }
        #endregion

        #region //Licensing - MAKE EM´ SUFFER A BIT

        private static bool LicenseException(License license)
        {
            //// check licensetype.
            return license.Type == LicenseType.Trial;
        }


        private void loadLicense()
        {
            publicKeyTb.Text = string.Empty;

            /*
                1. clear validation listbox.
                2. define a new stream and select and read the license.
                3. read the values from the license.
                4. validate the license (expiration date and signature).
             */

            using (StreamReader licenseRead = new StreamReader("license.txt"))
            {
                string currentLicense = licenseRead.ReadLine();
                publicKeyTb.Text = currentLicense;
                licenseRead.Close();
            }

        }

        private void validateLicense_Click(object sender, RoutedEventArgs e)
        {
            validateLicenseOnStart();

            if (licenseValid == false)
            {
                soundcloudView.Visibility = Visibility.Visible;
                settingsView.Visibility = Visibility.Collapsed;
                soundcloudViewButton.IsEnabled = true;
            }
        }


        public void validateLicenseOnStart()
        {
            var myStream = Stream.Null;

            try
            {
                var sr = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\lic.lic");
                myStream = sr.BaseStream;
                if (myStream.Length <= 0)
                {
                    return;
                }

                this.ulicense = License.Load(myStream);

                this.Title = this.ulicense.AdditionalAttributes.Get("Software") + " Licensed To '" + this.ulicense.Customer.Name + "'";

                this.publicKey = publicKeyTb.Text;
                var str = this.ValidateLicense(this.ulicense);

                this.licenseTb.Text = str;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Cannot read file from disk. Original error: " + ex.Message);
            }
            finally
            {
                //// Check this again, since we need to make sure we didn't throw an exception on open.
                if (myStream != null)
                {
                    myStream.Close();
                }

                validateLicenseSave();

            }

        }

        public void validateLicenseSave()
        {
            using (StreamWriter licenseWriter = new StreamWriter("license.txt", false))
            {
                licenseWriter.WriteLine(publicKeyTb.Text);
                licenseWriter.Close();
            }
        }


        private string ValidateLicense(License license)
        {
            //// validate license and define return value.
            const string ReturnValue = "License is Valid";

            var validationFailures =
                license.Validate()
                    .ExpirationDate()
                    .When(LicenseException)
                    .And()
                    .Signature(this.publicKey)
                    .AssertValidLicense();

            var failures = validationFailures as IValidationFailure[] ?? validationFailures.ToArray();

            if (!failures.Any() == true)
            {
                licenseValid = true;
                Trace.WriteLine(ReturnValue + " = " + licenseValid);
            }

            return !failures.Any() ? ReturnValue : failures.Aggregate(string.Empty, (current, validationFailure) => current + validationFailure.HowToResolve + ": " + "\r\n" + validationFailure.Message + "\r\n");
        }

        #endregion

        #region //Bottoms used to be cuckolds and sissies

        private void loadPageButton_Click(object sender, RoutedEventArgs e)
        {
            loadSongUrl();
        }

        private async void genPlaysButton_Click(object sender, RoutedEventArgs e)
        {
            //Dispose the Cancellation Token and Start again
            tokenSource.Dispose(); // Clean up old token source....
            tokenSource = new CancellationTokenSource(); // "Reset" the cancellation token source...

            await PutTaskDelay();
        }

        #endregion

        #region //Load the fucking songUrl and get over it - PROXYAUTOMATION
        public void loadSongUrl()
        {
            

            #region //Preference for Proxy
            if (proxyChechbox.IsChecked == true)
            {
                currentproxyaddress = Convert.ToString(proxyListbox.SelectedValue);


                

                Cef.UIThreadTaskFactory.StartNew(delegate
                {
                    var rc = Browser.GetBrowser().GetHost().RequestContext;
                    var v = new Dictionary<string, object>();
                    v["mode"] = "fixed_servers";
                    v["server"] = "" + currentproxyaddress;
                    string error;
                    bool success = rc.SetPreference("proxy", v, out error);
                    rc.GetAllPreferences(true);
                    Trace.WriteLine("Loading Page with PROXY SERVER: " + currentproxyaddress);   
                });

                

            }
            else
            {
                currentproxyaddress = "direct://";

                Cef.UIThreadTaskFactory.StartNew(delegate
                {
                    var rc = Browser.GetBrowser().GetHost().RequestContext;
                    var v = new Dictionary<string, object>();
                    v["mode"] = "fixed_servers";
                    v["server"] = "" + currentproxyaddress;
                    string error;
                    bool success = rc.SetPreference("proxy", v, out error);
                    rc.GetAllPreferences(true);
                    Trace.WriteLine("Loading with NO PROXY over " + currentproxyaddress);

                });
            }

            #endregion

            //populate Browser Address and reload the goatcanon
            Browser.Address = txtBox_songUrl.Text;
            Browser.Load(txtBox_songUrl.Text);

        }

        private void proxyAutomation()
        {
            if (proxyChechbox.IsChecked == true)
            {
                Trace.WriteLine("PROXIES LOADED: " + (proxyListbox.Items.Count - 1));

                if (proxyListbox.SelectedIndex < proxyListbox.Items.Count - 1)
                {
                    proxyListbox.SelectedIndex++;
                    Trace.WriteLine("SELECTED PROXY:" + proxyListbox.SelectedIndex);
                }
                else
                {
                    proxyListbox.SelectedIndex = 0;
                    Trace.WriteLine("SELECTED PROXY:" + proxyListbox.SelectedIndex);
                }
            }
        }

        #endregion

        #region //Doing some Task while the auto goat is shooting babies over the wall - SONG ROTATION
        //Some for-loop Magic here - to do the wanted TASK
        async Task PutTaskDelay()
        {
            //get Time between plays from textbox
            timebetweenPlays = Convert.ToInt16(tbPlays.Text) * 1000;

            //get maximal plays from textbox
            maxPlaysNumber = Convert.ToInt16(maxPlays.Text);


            Trace.WriteLine("LOADED SONGS: " + songSet.Tables[0].Rows.Count);

            try
            {
                for (int i = 1; i <= maxPlaysNumber; i++)
                {
                    automationrunning = true;
                    Trace.WriteLine("AUTOMATION RUNNING = " + automationrunning);
                    loadSongUrl();
                    automatedPlays++;
                    Trace.WriteLine("generated Plays: " + automatedPlays);
                    genPlaysNumber.Content = automatedPlays;
                    await Task.Delay(timebetweenPlays, tokenSource.Token);



                    //IF Rotation on cycle through the Song URL´s and get back to the beginning
                    if (rotationCheckBox.IsChecked == true)
                    {
                        if (additionalSongs.SelectedIndex < songSet.Tables[0].Rows.Count - 1)
                        {
                            additionalSongs.SelectedIndex++;
                            Trace.WriteLine("Selected Index: " + additionalSongs.SelectedIndex);


                            additionalSongs.ScrollIntoView(additionalSongs.SelectedItem);

                            //if (additionalSongs.SelectedIndex >= songSet.Tables[0].Rows.Count)
                            //{

                            //}


                        }
                        else
                        {
                            additionalSongs.SelectedIndex = 0;
                            Trace.WriteLine("Selected Index: " + additionalSongs.SelectedIndex);
                        }


                        
                    }

                    



                    proxyAutomation();


                }
            }


            //Catch me if you can

            catch (TaskCanceledException)

            {
                Trace.WriteLine("- We cancelled my quest, fucker! -");
                automationrunning = false;
                Trace.WriteLine("AUTOMATION RUNNING = " + automationrunning);
                

            }

            catch (Exception)

            {


            }
        }
        #endregion

        #region //Crap in the basement - LOAD PROXYLIST
        private void genPlaysCancel_Click(object sender, RoutedEventArgs e)
        {
            tokenSource.Cancel(true);
        }

        private void tbt_Valuechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            timebetweenPlays = Convert.ToInt32(tbPlays.Text);
        }

        private void loadProxies_Click(object sender, RoutedEventArgs e)
        {
            //Clear Listbox for god´s sake
            proxyListbox.ItemsSource = null;
            proxyListbox.Items.Clear();

            //populate listbox
            loadProxyList();

        }

        public void loadProxyList()
        {
            proxylist.Clear();

            using (var sr = new StreamReader(proxyListTxt))
            {
                while (sr.Peek() >= 0)
                proxylist.Add(sr.ReadLine());
            }

            proxyListbox.ItemsSource = proxylist;

            Trace.WriteLine("Proxylist loaded");


        }
        #endregion

        #region //Proxy Hole to stuff dick in
        //Use a motherfucking Proxyserver
        private void useProxyServer(object sender, RoutedEventArgs e)
        {

            currentproxyaddress = Convert.ToString(proxyListbox.SelectedValue);

            if (proxyChechbox.IsChecked == true)
                Trace.WriteLine("Proxy is Checked");

        }

        private void editProxies_Click(object sender, RoutedEventArgs e)
        {

            Process.Start(proxyListTxt);

        }


        #endregion

        #region //Handle your Staff, Mister Magician
        //textbox onKeyDownHandler
        private void scOnKeyHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                loadSongUrl();
            }
        } 
        #endregion

        #region //Accountlogin Automation Anon Alcoholics
        private void accountLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Grab Account Info und login

            //string script = "alert('Hello Fucker!');";
            //Browser.GetMainFrame().ExecuteJavaScriptAsync(script);




            //bring Login Screen to front
            string script2 = "document.getElementsByClassName('g-opacity-transition sc-button sc-button-medium loginButton')[1].click();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script2);



            //Get Input Focus
            string script3 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].focus();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script3);



            //Paste Username
            string script4 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[0].value =";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script4 + "'" + currentusername + "'");
            string controllstring = "Grab Account Values from: " + currentusername;
            Trace.WriteLine(controllstring);

            //ENTER Async
            waitMotherFucker();

            //Get Input Focus
            string script5 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].focus();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script5);

            //Paste Password Async
            waitSomeMoreMotherFucker();


        }

        public void accountLogin()
        {

            //bring Login Screen to front
            string script2 = "document.getElementsByClassName('g-opacity-transition sc-button sc-button-medium loginButton')[1].click();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script2);

            //Get Input Focus
            string script3 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].focus();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script3);

            //Paste Username
            string script4 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[0].value =";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script4 + "'" + currentusername + "'");
            string controllstring = "Grab Account Values from: " + currentusername;
            Trace.WriteLine(controllstring);

            //ENTER Async
            waitMotherFucker();

            //Get Input Focus
            string script5 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].focus();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script5);

            //Paste Password Async
            waitSomeMoreMotherFucker();
        }

        //Wait for What?!
        public async void waitMotherFucker()
        {

            Browser.Focus();
            await Task.Delay(2000);

            Browser.Focus();

            //KeyEvent Handler
            int keycode = 13; // or any other keycode
            KeyEvent keyEvent = new KeyEvent();
            keyEvent.Type = KeyEventType.KeyDown;
            keyEvent.WindowsKeyCode = keycode;
            keyEvent.NativeKeyCode = keycode;

            Browser.GetBrowser().GetHost().SendKeyEvent(keyEvent);


            Trace.WriteLine("ENTER");


        }

        public async void waitSomeMoreMotherFucker()
        {

            Browser.Focus();
            await Task.Delay(2000);

            Browser.Focus();

            string script7 = "document.getElementsByClassName('textfield__input sc-input sc-input-large').readOnly = false;";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script7);

            string script6 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].value = ";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script6 + "'" + currentpassword + "'");

            string controllstring = "PASSWORD JS: " + script6 + "'" + currentpassword + "'";
            Trace.WriteLine(controllstring);

            Trace.WriteLine("PASSWORD TRANSMITTED");

            //Enter Gain Async
            coolDownMotherFucker();

        }

        public async void coolDownMotherFucker()
        {

            Browser.Focus();
            await Task.Delay(2000);

            //Get Input Focus
            string script8 = "document.getElementsByClassName('textfield__input sc-input sc-input-large')[1].focus();";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script8);

            Browser.Focus();

            //KeyEvent Handler
            int keycode = 13; // or any other keycode
            KeyEvent keyEvent = new KeyEvent();
            keyEvent.Type = KeyEventType.KeyDown;
            keyEvent.WindowsKeyCode = keycode;
            keyEvent.NativeKeyCode = keycode;

            Browser.GetBrowser().GetHost().SendKeyEvent(keyEvent);


            Trace.WriteLine("ENTER");


        }

        public async void justwaitaBit()
        {

            Browser.Focus();
            await Task.Delay(3000);

            

            Browser.Focus();

            
            Trace.WriteLine("PAUSE INPUT");


        }

        //Send Key Event
        public static class SendKeys
        {
            /// <summary>
            ///   Sends the specified key.
            /// </summary>
            /// <param name="key">The key.</param>
            public static void Send(Key key)
            {
                if (Keyboard.PrimaryDevice != null)
                {
                    if (Keyboard.PrimaryDevice.ActiveSource != null)
                    {
                        var e1 = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Down) { RoutedEvent = Keyboard.KeyDownEvent };
                        InputManager.Current.ProcessInput(e1);
                    }
                }
            }
        }

        private void accountLogoutButton_Click(object sender, RoutedEventArgs e)
        {
            //log off from account 
            //Continue Button Drücken
            string script10 = "window.location = 'https://soundcloud.com/logout'; ";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script10);

            Browser.Focus();

            string script11 = defaultSongUrl;
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script11);

            secretWaiter();

        }

        public void accountLogout()
        {
            //log off from account 
            //Continue Button Drücken
            string script10 = "window.location = 'https://soundcloud.com/logout'; ";
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script10);

            Browser.Focus();

            string script11 = defaultSongUrl;
            Browser.GetMainFrame().ExecuteJavaScriptAsync(script11);

            secretWaiter();

        }


        public async void secretWaiter()
        {

            
            await Task.Delay(2000);

            Browser.Focus();
            loadSongUrl();
            Trace.WriteLine("BACK TO THE FUTURE");


        }


        #endregion

        #region //The whole fucking Account Data manipulation
        private void loadAccountList_Click(object sender, RoutedEventArgs e)
        {
            loadAccountsDataGrid();

        }

        public void creatDatagridcolumns()
        {

        }

        public void loadAccountsDataGrid()
        {
            try
            {
                dataSet.Clear();
                //load the accountlist.xml          
                dataSet.ReadXml(accountDataXml);

                DataView accountdataView = new DataView(dataSet.Tables[0]);
                accountListDataGrid.ItemsSource = accountdataView;
                Trace.WriteLine("Accountlist loaded");
            }
            catch
            {
            }



        }

        private void saveAccountList_Click(object sender, RoutedEventArgs e)
        {
            dataSet.WriteXml(accountDataXml);
        }

        public void getSelectedAccountData()
        {
            //do select and parse



        }

        private void accountListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                // find row for the first selected item
                DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(e.AddedItems[0]);
                if (row != null)
                {
                    DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
                    // find grid cell object for the cell with index 0
                    DataGridCell cell = presenter.ItemContainerGenerator.ContainerFromIndex(0) as DataGridCell;
                    if (cell != null)
                    {
                        currentusername = (((TextBlock)cell.Content).Text);
                    }

                    DataGridCellsPresenter presenter2 = GetVisualChild<DataGridCellsPresenter>(row);
                    // find grid cell object for the cell with index 0
                    DataGridCell cell2 = presenter2.ItemContainerGenerator.ContainerFromIndex(1) as DataGridCell;
                    if (cell != null)
                    {
                        currentpassword = (((TextBlock)cell2.Content).Text);
                    }

                }
            }


            Trace.WriteLine("Selection changed to: " + currentusername);

            userNameTb.Text = currentusername;
            passwordTb.Text = currentpassword;

        }

        static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T child = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = v as T;
                if (child == null) child = GetVisualChild<T>(v);
                if (child != null) break;
            }
            return child;
        }




        #endregion

        #region //AccountSwitchAutomation 

        public void accountSwitchAutomation()
        {
            accountLogout();
            Browser.Load(Browser.Address);
            

            if (accountListDataGrid.SelectedIndex < songSet.Tables[0].Rows.Count - 1)
            {
                accountListDataGrid.SelectedIndex++;
                Trace.WriteLine("Account used: " + accountListDataGrid.SelectedIndex);


                accountListDataGrid.ScrollIntoView(accountListDataGrid.SelectedItem);

                //if (additionalSongs.SelectedIndex >= songSet.Tables[0].Rows.Count)
                //{

                //}
                justwaitaBit();
                accountLogin();


            }
            else
            {
                additionalSongs.SelectedIndex = 0;
                Trace.WriteLine("Selected Index: " + additionalSongs.SelectedIndex);
            }



        }


        #endregion

        #region //Additional Bongs to smoke   - MORE MUSIC

        public void loadSoundCloudSongs()
        {
            try
            {
                songSet.Clear();
                //load the accountlist.xml          
                songSet.ReadXml(songsDataXml);

                DataView songSetView = new DataView(songSet.Tables[0]);
                additionalSongs.ItemsSource = songSetView;
                additionalSongs.SelectedIndex = 0;
                additionalSongs.EnableRowVirtualization = false;
                Trace.WriteLine("Songlist loaded");
            }
            catch
            {

            }

        }


        private void saveSongList_Click(object sender, RoutedEventArgs e)
        {
            songSet.WriteXml(songsDataXml);
        }


        private void songSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataGrid songSet = sender as DataGrid;
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                // find row for the first selected item
                DataGridRow row = (DataGridRow)songSet.ItemContainerGenerator.ContainerFromItem(e.AddedItems[0]);
                if (row != null)
                {
                    DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
                    // find grid cell object for the cell with index 0
                    DataGridCell cell = presenter.ItemContainerGenerator.ContainerFromIndex(0) as DataGridCell;
                    if (cell != null)
                    {
                        defaultSongUrl = (((TextBlock)cell.Content).Text);
                    }

                }

                txtBox_songUrl.Text = defaultSongUrl;

                Trace.WriteLine("NEXT SONG: " + defaultSongUrl);
            }
        }


        #endregion

        #region //Auto Follow Bot, Like HeliCopter, Repost-o-Mat

        private async void autoFollowButt_Click(object sender, RoutedEventArgs e)
        {
            maxFollowAccounts = Convert.ToInt32(maxFollowAccountsTxtBox.Text);

            await followWaiter();

            

            for (int i = 1; i <= maxFollowAccounts; i++)
            {
                //int timemofo = Convert.ToInt16(RandomString(3));
                //Trace.WriteLine("Random Generator: " + timemofo);

                int ticksMilli = rnd.Next(randomnumber1, randomnumber2);

                //badgeList__item

                string autoFollow = "document.getElementsByClassName('sc-button-follow sc-button sc-button-small sc-button-responsive')[";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(autoFollow + i + "].click();");
                Trace.WriteLine("Followed: " + i );
                string autoFollow1 = "document.getElementsByClassName('sc-button-follow sc-button sc-button-small sc-button-responsive')[";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(autoFollow1 + i + "].focus();");
                string zoomFollow = "document.getElementsByClassName('badgeList__item')[";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(zoomFollow + i + "].style.width = '25%'");
                Browser.GetMainFrame().ExecuteJavaScriptAsync(zoomFollow + i + "].style.width = '10%'");
                followedAccountsCount++;
                followedAccountsL.Content = followedAccountsCount;
                await Task.Delay(ticksMilli);
                Trace.WriteLine("Random Range Generator: " + ticksMilli + "ms");
            }

            Trace.WriteLine("│--FOLLOWBOT FINISHED");

        }

        public async Task followWaiter()
        {
            int maxFollowScroll = maxFollowAccounts / 20;

            await Task.Delay(1000);

            Browser.Focus();

            for (int i = 1; i <= maxFollowScroll; i++)
            {
                string scrollinView = "document.getElementsByClassName('loading regular m-padded')[0].scrollIntoView();";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(scrollinView);
                Trace.WriteLine("Scrolled in View " + i);
                await Task.Delay(750);
            }

        }

        private async void likeHelicopter_Click(object sender, RoutedEventArgs e)
        {
            maxLikes = Convert.ToInt32(maxLikesTxtBox.Text);

            await followWaiter();

            for (int i = maxLikes; i >= 0; i--)
            {
                string autoLike = "document.getElementsByClassName('sc-button-like sc-button sc-button-small sc-button-responsive')[";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(autoLike + i + "].click();");
                Trace.WriteLine("Liked: " + i);
                likedSongsCount++;
                likedLabel.Content = likedSongsCount;
                await Task.Delay(175);
            }

            Trace.WriteLine("│--♥ HELICOPTER FINISHED");

        }



        private async void repostBot_Click(object sender, RoutedEventArgs e)
        {
            maxreposts = Convert.ToInt32(maxRepostsTxt.Text);

            await followWaiter();

            for (int i = maxreposts; i >= 0; i--)
            {
                string autoRepost = "document.getElementsByClassName('sc-button-repost sc-button sc-button-small sc-button-responsive')[";
                Browser.GetMainFrame().ExecuteJavaScriptAsync(autoRepost + i + "].click();");
                Trace.WriteLine("Reposted: " + i);
                repostedCount++;
                repostsLabel.Content = repostedCount;
                await Task.Delay(175);
            }

            Trace.WriteLine("│--REPOST-O-MAT FINISHED FARMING");


        }


        #endregion

        #region //TITLEBAR NAVIGATION & Flyou Menu

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            soundcloudView.Visibility = Visibility.Collapsed;
            settingsView.Visibility = Visibility.Visible;
        }

        private void soundcloudPenView_Click(object sender, RoutedEventArgs e)
        {
            soundcloudView.Visibility = Visibility.Visible;
            settingsView.Visibility = Visibility.Collapsed;
        }

        private void helpDesk_Click(object sender, RoutedEventArgs e)
        {
            Helpdesk.IsOpen = true;
            helpDeskContent();
        }

        public void helpDeskContent()
        {
            soundcloudView.Visibility = Visibility.Visible;
            settingsView.Visibility = Visibility.Collapsed;

            TextRange range;
            FileStream fStream;
            if (File.Exists("help.rtf"))
            {
                range = new TextRange(helpDeskDoc.Document.ContentStart, helpDeskDoc.Document.ContentEnd);
                fStream = new FileStream("help.rtf", FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.Rtf);
                fStream.Close();
            }
        }

        #endregion

        #region //Menuhandler - YOU CAN ADJUST THE FUCKING MENU HERE
        private class MenuHandler : IContextMenuHandler
        {
            public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
            {
                model.Clear();

            }

            public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
            {
                return false;
            }

            public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
            {
                //var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;

                //chromiumWebBrowser.Dispatcher.Invoke(() =>
                //{
                //    chromiumWebBrowser.ContextMenu = null;
                //});
            }

            public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
            {
                return false;

                //var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;

                ////IMenuModel is only valid in the context of this method, so need to read the values before invoking on the UI thread
                //var menuItems = GetMenuItems(model);

                //chromiumWebBrowser.Dispatcher.Invoke(() =>
                //{
                //    var menu = new ContextMenu
                //    {
                //        IsOpen = true
                //    };

                //    RoutedEventHandler handler = null;

                //    handler = (s, e) =>
                //    {
                //        menu.Closed -= handler;

                //        //If the callback has been disposed then it's already been executed
                //        //so don't call Cancel
                //        if(!callback.IsDisposed)
                //        { 
                //            callback.Cancel();
                //        }
                //    };

                //    menu.Closed += handler;

                //    foreach (var item in menuItems)
                //    {
                //        menu.Items.Add(new MenuItem
                //        {
                //            Header = item.Item1,
                //            Command = new RelayCommand(() => { callback.Continue(item.Item2, CefEventFlags.None); })
                //        });
                //    }
                //    chromiumWebBrowser.ContextMenu = menu;
                //});

                //return true;
            }

            private static IEnumerable<Tuple<string, CefMenuCommand>> GetMenuItems(IMenuModel model)
            {
                var list = new List<Tuple<string, CefMenuCommand>>();
                for (var i = 0; i < model.Count; i++)
                {
                    var header = model.GetLabelAt(i);
                    var commandId = model.GetCommandIdAt(i);
                    list.Add(new Tuple<string, CefMenuCommand>(header, commandId));
                }

                return list;
            }
        }

        #endregion

        #region //Datagird Manipulation

        private void songSetDelete_Click(object sender, RoutedEventArgs e)
        {
            if (additionalSongs.SelectedItem != null)
            {
                ((DataRowView)(additionalSongs.SelectedItem)).Row.Delete();
            }
        }

        private void accountDelete_Click(object sender, RoutedEventArgs e)
        {
            if (accountListDataGrid.SelectedItem != null)
            {
                ((DataRowView)(accountListDataGrid.SelectedItem)).Row.Delete();
            }
        }


        

        #endregion

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        #region //DEBUG YOUR BASEMENT THEY SAID, SPIDERS, MONKEYS, OLD DILDOS! EVERYTHING! 

        private void devToolsButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.ShowDevTools();
        }

        private void openNewInstance(object sender, RoutedEventArgs e)
        {
            Process.Start(newInstance);
        }

        #endregion

        
    }
}
