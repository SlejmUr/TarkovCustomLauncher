namespace TarkovCustomLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainProfile = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PostChanges = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveServer = new System.Windows.Forms.Button();
            this.GetServerInfo = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.profileBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.GameBox = new System.Windows.Forms.ComboBox();
            this.EditionBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.passwordboxMain = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 112);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1020, 426);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.passwordboxMain);
            this.tabPage1.Controls.Add(this.mainProfile);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.startGameButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Bender", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // mainProfile
            // 
            this.mainProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainProfile.FormattingEnabled = true;
            this.mainProfile.Location = new System.Drawing.Point(411, 150);
            this.mainProfile.Name = "mainProfile";
            this.mainProfile.Size = new System.Drawing.Size(161, 22);
            this.mainProfile.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Select Profile";
            // 
            // startGameButton
            // 
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameButton.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(427, 289);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(131, 28);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Start the game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bender", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome in the Ultimate Launcher where you can start AE, SIT , MTGA!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PostChanges);
            this.tabPage2.Controls.Add(this.registerButton);
            this.tabPage2.Controls.Add(this.loginButton);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.SaveServer);
            this.tabPage2.Controls.Add(this.GetServerInfo);
            this.tabPage2.Controls.Add(this.serverLabel);
            this.tabPage2.Controls.Add(this.serverBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.LoadProfileButton);
            this.tabPage2.Controls.Add(this.profileBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SaveProfileButton);
            this.tabPage2.Controls.Add(this.GameBox);
            this.tabPage2.Controls.Add(this.EditionBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.passwordBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.userBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server / Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PostChanges
            // 
            this.PostChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PostChanges.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PostChanges.ForeColor = System.Drawing.Color.Black;
            this.PostChanges.Location = new System.Drawing.Point(246, 272);
            this.PostChanges.Name = "PostChanges";
            this.PostChanges.Size = new System.Drawing.Size(75, 23);
            this.PostChanges.TabIndex = 28;
            this.PostChanges.Text = "Post**";
            this.PostChanges.UseVisualStyleBackColor = true;
            this.PostChanges.Click += new System.EventHandler(this.PostChanges_Click);
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(832, 113);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 27;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(725, 113);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 26;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "*Saving with server will tied to accountID\r\n**Posting changes will send to server" +
    "IP";
            // 
            // SaveServer
            // 
            this.SaveServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveServer.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveServer.ForeColor = System.Drawing.Color.Black;
            this.SaveServer.Location = new System.Drawing.Point(553, 113);
            this.SaveServer.Name = "SaveServer";
            this.SaveServer.Size = new System.Drawing.Size(75, 23);
            this.SaveServer.TabIndex = 24;
            this.SaveServer.Text = "Save*";
            this.SaveServer.UseVisualStyleBackColor = true;
            this.SaveServer.Click += new System.EventHandler(this.SaveServer_Click);
            // 
            // GetServerInfo
            // 
            this.GetServerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetServerInfo.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetServerInfo.ForeColor = System.Drawing.Color.Black;
            this.GetServerInfo.Location = new System.Drawing.Point(448, 113);
            this.GetServerInfo.Name = "GetServerInfo";
            this.GetServerInfo.Size = new System.Drawing.Size(75, 23);
            this.GetServerInfo.TabIndex = 23;
            this.GetServerInfo.Text = "Get";
            this.GetServerInfo.UseVisualStyleBackColor = true;
            this.GetServerInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(448, 148);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(180, 16);
            this.serverLabel.TabIndex = 22;
            this.serverLabel.Text = "Information about Server:";
            // 
            // serverBox
            // 
            this.serverBox.FormattingEnabled = true;
            this.serverBox.Location = new System.Drawing.Point(480, 62);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(161, 22);
            this.serverBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Server IP";
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadProfileButton.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadProfileButton.ForeColor = System.Drawing.Color.Black;
            this.LoadProfileButton.Location = new System.Drawing.Point(778, 148);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(75, 23);
            this.LoadProfileButton.TabIndex = 17;
            this.LoadProfileButton.Text = "Load";
            this.LoadProfileButton.UseVisualStyleBackColor = true;
            this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // profileBox
            // 
            this.profileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileBox.FormattingEnabled = true;
            this.profileBox.Location = new System.Drawing.Point(725, 62);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(182, 22);
            this.profileBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select Profile";
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveProfileButton.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveProfileButton.ForeColor = System.Drawing.Color.Black;
            this.SaveProfileButton.Location = new System.Drawing.Point(160, 272);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfileButton.TabIndex = 14;
            this.SaveProfileButton.Text = "Save";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // GameBox
            // 
            this.GameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameBox.FormattingEnabled = true;
            this.GameBox.Items.AddRange(new object[] {
            "Stay In Tarkov",
            "Altered Escape",
            "MTGA"});
            this.GameBox.Location = new System.Drawing.Point(160, 227);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(161, 22);
            this.GameBox.TabIndex = 13;
            // 
            // EditionBox
            // 
            this.EditionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditionBox.FormattingEnabled = true;
            this.EditionBox.Items.AddRange(new object[] {
            "Developer",
            "Edge Of Darkness"});
            this.EditionBox.Location = new System.Drawing.Point(160, 172);
            this.EditionBox.Name = "EditionBox";
            this.EditionBox.Size = new System.Drawing.Size(161, 22);
            this.EditionBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Game Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edition";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(160, 117);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(161, 23);
            this.passwordBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create/Change Profile";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(160, 62);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(161, 23);
            this.userBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1012, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Launch Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Bender", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 60);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1020, 47);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // passwordboxMain
            // 
            this.passwordboxMain.Location = new System.Drawing.Point(411, 197);
            this.passwordboxMain.Name = "passwordboxMain";
            this.passwordboxMain.PasswordChar = '*';
            this.passwordboxMain.Size = new System.Drawing.Size(161, 22);
            this.passwordboxMain.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1020, 540);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Bender", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarkov Ultimate Launcher";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Button startGameButton;
        private TextBox userBox;
        private TabPage tabPage3;
        private ComboBox EditionBox;
        private Label label6;
        private Label label5;
        private TextBox passwordBox;
        private Label label4;
        private Label label1;
        private ComboBox GameBox;
        private Button SaveProfileButton;
        private ComboBox profileBox;
        private Label label7;
        private Button LoadProfileButton;
        private Label label8;
        private Label label9;
        private ComboBox serverBox;
        private Label serverLabel;
        private Button GetServerInfo;
        private Button SaveServer;
        private ComboBox mainProfile;
        private Label label11;
        private Label label10;
        private Button registerButton;
        private Button loginButton;
        private Button PostChanges;
        private TextBox passwordboxMain;
    }
}