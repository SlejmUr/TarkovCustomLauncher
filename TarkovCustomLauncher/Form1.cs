using MaterialSkin;
using MaterialSkin.Controls;
using Ionic.Zlib;
using System.Net;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace TarkovCustomLauncher
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            userconfigs = new();
        }
        static string basic_inf = "Information about Server:\n";
        public static List<Config.User> userconfigs;
        private void button4_Click(object sender, EventArgs e)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var client = new HttpClient(clientHandler);
            string get;

            if (!serverBox.Text.EndsWith('/')) { serverBox.Text += "/"; }

            if (!serverBox.Text.Contains("launcher/server/connect"))
            {
                get = serverBox.Text + "launcher/server/connect";
            }
            else
            {
                get = serverBox.Text;
            }
            var xx = client.GetAsync(get).Result;
            var rsp = xx.Content.ReadAsByteArrayAsync().Result;
            var uncmp = ZlibStream.UncompressString(rsp);
            var fromnet = JsonConvert.DeserializeObject<Config.Server>(uncmp);
            string thingy = "IP: " + fromnet.BackendUrl + "\nName: "
                + fromnet.Name;

            serverLabel.Text = basic_inf + thingy;
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            var username = userBox.Text;
            var server = serverBox.Text;
            var password = passwordBox.Text;
            var edition = EditionBox.Text;
            var gametype = GameBox.Text;

            Config.User user = new();
            user.Name = username;
            user.Password = DoMd5(password);
            user.Edition = edition;
            user.GameType = gametype;
            if (!string.IsNullOrWhiteSpace(server))
            {
                user.ServerIP = server;
            }
            if (File.Exists("user.json"))
            {
                userconfigs = JsonConvert.DeserializeObject<List<Config.User>>(File.ReadAllText("user.json"));
            }

            if (!userconfigs.Where(x=>x.Name == username && x.ServerIP == server).Any())
            {
                profileBox.Items.Add(username + " | " + gametype);
                mainProfile.Items.Add(username + " | " + gametype);
                userconfigs.Add(user);

            }
            File.WriteAllText("user.json", JsonConvert.SerializeObject(userconfigs));
        }








        private void LoadProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveServer_Click(object sender, EventArgs e)
        {

        }


        private void PostChanges_Click(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mainProfile.Text))
            {
                return;
            }

            foreach (var user in userconfigs)
            { 
            
            
            
            }
        }



        static bool CheckMD5(string passw, string saved)
        {
            var pw5 = DoMd5(passw);

            if (saved != pw5)
            {
                return false;
            }

            return true;
        }
        static string DoMd5(string src)
        {
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(src);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                // Output the MD5 hash
                Console.WriteLine("The MD5 hash of " + src + " is: " + hash);
                return hash;
            }
        }

    }
}