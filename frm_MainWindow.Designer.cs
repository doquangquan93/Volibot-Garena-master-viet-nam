/*
 * VoliBot GUI a.k.a. RitoBot GUI is part of the opensource VoliBot AutoQueuer project.
 * Credits to: shalzuth, Maufeat, imsosharp
 * Find assemblies for this AutoQueuer on LeagueSharp's official forum at:
 * http://www.joduska.me/
 * You are allowed to copy, edit and distribute this project,
 * as long as you don't touch this notice and you release your project with source.
 */

namespace RitoBot
{
    partial class frm_MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainWindow));
            this.mainWindowSplitContainer = new System.Windows.Forms.SplitContainer();
            this.configTabControl = new System.Windows.Forms.TabControl();
            this.accountsTab = new System.Windows.Forms.TabPage();
            this.btn_an_lol = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.input_solanchoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LoadedAccounts = new System.Windows.Forms.RichTextBox();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.QueueTypeInput = new System.Windows.Forms.ComboBox();
            this.QueueTypeLabel = new System.Windows.Forms.Label();
            this.addAccountsBtn = new System.Windows.Forms.Button();
            this.newPasswordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newUserNameInput = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_width = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MaxLevelInput = new System.Windows.Forms.TextBox();
            this.maxLevelLabel = new System.Windows.Forms.Label();
            this.MaxBotsInput = new System.Windows.Forms.TextBox();
            this.maxBotsLabel = new System.Windows.Forms.Label();
            this.DefaultChampionInput = new System.Windows.Forms.ComboBox();
            this.defaultChampionLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.BuyBoostInput = new System.Windows.Forms.ComboBox();
            this.BuyBoostLabel = new System.Windows.Forms.Label();
            this.Spell2Input = new System.Windows.Forms.ComboBox();
            this.spell2Label = new System.Windows.Forms.Label();
            this.Spell1Input = new System.Windows.Forms.ComboBox();
            this.spell1Label = new System.Windows.Forms.Label();
            this.RegionInput = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.LauncherPathInput = new System.Windows.Forms.TextBox();
            this.launcherPathLabel = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).BeginInit();
            this.mainWindowSplitContainer.Panel1.SuspendLayout();
            this.mainWindowSplitContainer.Panel2.SuspendLayout();
            this.mainWindowSplitContainer.SuspendLayout();
            this.configTabControl.SuspendLayout();
            this.accountsTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowSplitContainer
            // 
            this.mainWindowSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainWindowSplitContainer.Name = "mainWindowSplitContainer";
            // 
            // mainWindowSplitContainer.Panel1
            // 
            this.mainWindowSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.configTabControl);
            // 
            // mainWindowSplitContainer.Panel2
            // 
            this.mainWindowSplitContainer.Panel2.Controls.Add(this.console);
            this.mainWindowSplitContainer.Size = new System.Drawing.Size(984, 602);
            this.mainWindowSplitContainer.SplitterDistance = 326;
            this.mainWindowSplitContainer.TabIndex = 0;
            // 
            // configTabControl
            // 
            this.configTabControl.Controls.Add(this.accountsTab);
            this.configTabControl.Controls.Add(this.settingsTab);
            this.configTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedIndex = 0;
            this.configTabControl.Size = new System.Drawing.Size(326, 602);
            this.configTabControl.TabIndex = 1;
            this.configTabControl.SelectedIndexChanged += new System.EventHandler(this.configTabControl_SelectedIndexChanged);
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.btn_an_lol);
            this.accountsTab.Controls.Add(this.button6);
            this.accountsTab.Controls.Add(this.input_solanchoi);
            this.accountsTab.Controls.Add(this.label1);
            this.accountsTab.Controls.Add(this.button4);
            this.accountsTab.Controls.Add(this.button2);
            this.accountsTab.Controls.Add(this.button1);
            this.accountsTab.Controls.Add(this.LoadedAccounts);
            this.accountsTab.Controls.Add(this.accountsLabel);
            this.accountsTab.Controls.Add(this.QueueTypeInput);
            this.accountsTab.Controls.Add(this.QueueTypeLabel);
            this.accountsTab.Controls.Add(this.addAccountsBtn);
            this.accountsTab.Controls.Add(this.newPasswordInput);
            this.accountsTab.Controls.Add(this.passwordLabel);
            this.accountsTab.Controls.Add(this.newUserNameInput);
            this.accountsTab.Controls.Add(this.userNameLabel);
            this.accountsTab.Location = new System.Drawing.Point(4, 22);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountsTab.Size = new System.Drawing.Size(318, 576);
            this.accountsTab.TabIndex = 0;
            this.accountsTab.Text = "Tài khoản";
            this.accountsTab.UseVisualStyleBackColor = true;
            // 
            // btn_an_lol
            // 
            this.btn_an_lol.Location = new System.Drawing.Point(6, 224);
            this.btn_an_lol.Name = "btn_an_lol";
            this.btn_an_lol.Size = new System.Drawing.Size(97, 44);
            this.btn_an_lol.TabIndex = 15;
            this.btn_an_lol.Text = "Bật Auto Check";
            this.btn_an_lol.UseVisualStyleBackColor = true;
            this.btn_an_lol.Click += new System.EventHandler(this.btn_an_lol_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(123, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 19);
            this.button6.TabIndex = 14;
            this.button6.Text = "Lấy Mã Token";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // input_solanchoi
            // 
            this.input_solanchoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_solanchoi.Location = new System.Drawing.Point(3, 116);
            this.input_solanchoi.Name = "input_solanchoi";
            this.input_solanchoi.Size = new System.Drawing.Size(312, 20);
            this.input_solanchoi.TabIndex = 13;
            this.input_solanchoi.Text = "999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số lần chơi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xóa Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bắt Đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadedAccounts
            // 
            this.LoadedAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadedAccounts.Location = new System.Drawing.Point(3, 304);
            this.LoadedAccounts.Name = "LoadedAccounts";
            this.LoadedAccounts.Size = new System.Drawing.Size(318, 264);
            this.LoadedAccounts.TabIndex = 3;
            this.LoadedAccounts.Text = "";
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.ForeColor = System.Drawing.Color.Black;
            this.accountsLabel.Location = new System.Drawing.Point(3, 278);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(83, 13);
            this.accountsLabel.TabIndex = 2;
            this.accountsLabel.Text = "Logs tài khoản :";
            // 
            // QueueTypeInput
            // 
            this.QueueTypeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.QueueTypeInput.FormattingEnabled = true;
            this.QueueTypeInput.Items.AddRange(new object[] {
            "NORMAL_5x5",
            "NORMAL_3x3",
            "INTRO_BOT",
            "BEGINNER_BOT",
            "MEDIUM_BOT",
            "ARAM"});
            this.QueueTypeInput.Location = new System.Drawing.Point(3, 82);
            this.QueueTypeInput.Name = "QueueTypeInput";
            this.QueueTypeInput.Size = new System.Drawing.Size(312, 21);
            this.QueueTypeInput.TabIndex = 6;
            this.QueueTypeInput.Text = "MEDIUM_BOT";
            // 
            // QueueTypeLabel
            // 
            this.QueueTypeLabel.AutoSize = true;
            this.QueueTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QueueTypeLabel.Location = new System.Drawing.Point(3, 69);
            this.QueueTypeLabel.Name = "QueueTypeLabel";
            this.QueueTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.QueueTypeLabel.TabIndex = 5;
            this.QueueTypeLabel.Text = "Chế độ chơi";
            // 
            // addAccountsBtn
            // 
            this.addAccountsBtn.Location = new System.Drawing.Point(109, 174);
            this.addAccountsBtn.Name = "addAccountsBtn";
            this.addAccountsBtn.Size = new System.Drawing.Size(104, 44);
            this.addAccountsBtn.TabIndex = 4;
            this.addAccountsBtn.Text = "Lưu tài khoản";
            this.addAccountsBtn.UseVisualStyleBackColor = true;
            this.addAccountsBtn.Click += new System.EventHandler(this.addAccountsBtn_Click);
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.newPasswordInput.Location = new System.Drawing.Point(3, 49);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(312, 20);
            this.newPasswordInput.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordLabel.Location = new System.Drawing.Point(3, 36);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "GarenaToken";
            // 
            // newUserNameInput
            // 
            this.newUserNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.newUserNameInput.Location = new System.Drawing.Point(3, 16);
            this.newUserNameInput.Name = "newUserNameInput";
            this.newUserNameInput.Size = new System.Drawing.Size(312, 20);
            this.newUserNameInput.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNameLabel.Location = new System.Drawing.Point(3, 3);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Tài khoản";
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.button10);
            this.settingsTab.Controls.Add(this.label5);
            this.settingsTab.Controls.Add(this.label4);
            this.settingsTab.Controls.Add(this.input_height);
            this.settingsTab.Controls.Add(this.label3);
            this.settingsTab.Controls.Add(this.input_width);
            this.settingsTab.Controls.Add(this.button9);
            this.settingsTab.Controls.Add(this.button8);
            this.settingsTab.Controls.Add(this.button7);
            this.settingsTab.Controls.Add(this.button5);
            this.settingsTab.Controls.Add(this.button3);
            this.settingsTab.Controls.Add(this.MaxLevelInput);
            this.settingsTab.Controls.Add(this.maxLevelLabel);
            this.settingsTab.Controls.Add(this.MaxBotsInput);
            this.settingsTab.Controls.Add(this.maxBotsLabel);
            this.settingsTab.Controls.Add(this.DefaultChampionInput);
            this.settingsTab.Controls.Add(this.defaultChampionLabel);
            this.settingsTab.Controls.Add(this.saveBtn);
            this.settingsTab.Controls.Add(this.BuyBoostInput);
            this.settingsTab.Controls.Add(this.BuyBoostLabel);
            this.settingsTab.Controls.Add(this.Spell2Input);
            this.settingsTab.Controls.Add(this.spell2Label);
            this.settingsTab.Controls.Add(this.Spell1Input);
            this.settingsTab.Controls.Add(this.spell1Label);
            this.settingsTab.Controls.Add(this.RegionInput);
            this.settingsTab.Controls.Add(this.regionLabel);
            this.settingsTab.Controls.Add(this.LauncherPathInput);
            this.settingsTab.Controls.Add(this.launcherPathLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(318, 576);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Cài đặt";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(6, 425);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 52);
            this.button10.TabIndex = 33;
            this.button10.Text = "Nút Test";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tùy chỉnh độ phân giải màn hình LOL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cao ( height ):";
            // 
            // input_height
            // 
            this.input_height.Location = new System.Drawing.Point(238, 332);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(74, 20);
            this.input_height.TabIndex = 30;
            this.input_height.Text = "768";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Dài ( width ):";
            // 
            // input_width
            // 
            this.input_width.Location = new System.Drawing.Point(73, 332);
            this.input_width.Name = "input_width";
            this.input_width.Size = new System.Drawing.Size(74, 20);
            this.input_width.TabIndex = 28;
            this.input_width.Text = "1024";
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(212, 516);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 52);
            this.button9.TabIndex = 26;
            this.button9.Text = "KT Start LOL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(106, 516);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 52);
            this.button8.TabIndex = 25;
            this.button8.Text = "KT thư mục LOL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(6, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 52);
            this.button7.TabIndex = 24;
            this.button7.Text = "Backup cấu hình";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(109, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 52);
            this.button5.TabIndex = 23;
            this.button5.Text = "Khôi phục giao diện măc định";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(212, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 52);
            this.button3.TabIndex = 22;
            this.button3.Text = "Giao diện Mod";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MaxLevelInput
            // 
            this.MaxLevelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxLevelInput.Location = new System.Drawing.Point(3, 252);
            this.MaxLevelInput.Name = "MaxLevelInput";
            this.MaxLevelInput.Size = new System.Drawing.Size(312, 20);
            this.MaxLevelInput.TabIndex = 21;
            this.MaxLevelInput.Text = "31";
            // 
            // maxLevelLabel
            // 
            this.maxLevelLabel.AutoSize = true;
            this.maxLevelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.maxLevelLabel.Location = new System.Drawing.Point(3, 239);
            this.maxLevelLabel.Name = "maxLevelLabel";
            this.maxLevelLabel.Size = new System.Drawing.Size(52, 13);
            this.maxLevelLabel.TabIndex = 20;
            this.maxLevelLabel.Text = "Max level";
            // 
            // MaxBotsInput
            // 
            this.MaxBotsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxBotsInput.Location = new System.Drawing.Point(3, 219);
            this.MaxBotsInput.Name = "MaxBotsInput";
            this.MaxBotsInput.Size = new System.Drawing.Size(312, 20);
            this.MaxBotsInput.TabIndex = 19;
            this.MaxBotsInput.Text = "1";
            // 
            // maxBotsLabel
            // 
            this.maxBotsLabel.AutoSize = true;
            this.maxBotsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.maxBotsLabel.Location = new System.Drawing.Point(3, 206);
            this.maxBotsLabel.Name = "maxBotsLabel";
            this.maxBotsLabel.Size = new System.Drawing.Size(88, 13);
            this.maxBotsLabel.TabIndex = 18;
            this.maxBotsLabel.Text = "Max bots running";
            // 
            // DefaultChampionInput
            // 
            this.DefaultChampionInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.DefaultChampionInput.FormattingEnabled = true;
            this.DefaultChampionInput.Items.AddRange(new object[] {
            "RANDOM",
            "AATROX",
            "AHRI",
            "AKALI",
            "ALISTAR",
            "AMUMU",
            "ANIVIA",
            "ANNIE",
            "ASHE",
            "AZIR",
            "BLITZCRANK",
            "BRAND",
            "BRAUM",
            "CAITLYN",
            "CASSIOPEIA",
            "CHOGATH",
            "CORKI",
            "DARIUS",
            "DIANA",
            "MUNDO",
            "DRAVEN",
            "ELISE",
            "EVELYNN",
            "EZREAL",
            "FIDDLESTICKS",
            "FIORA",
            "FIZZ",
            "GALIO",
            "GANGPLANK",
            "GAREN",
            "GNAR",
            "GRAGAS",
            "GRAVES",
            "HECARIM",
            "HEIMERDIGER",
            "IRELIA",
            "JANNA",
            "JARVAN",
            "JAX",
            "JAYCE",
            "JINX",
            "KALISTA",
            "KARMA",
            "KARTHUS",
            "KASSADIN",
            "KATARINA",
            "KAYLE",
            "KENNEN",
            "KHAZIX",
            "KOGMAW",
            "LEBLANC",
            "LEESIN",
            "LEONA",
            "LISSANDRA",
            "LUCIAN",
            "LULU",
            "LUX",
            "MALPHITE",
            "MALZAHAR",
            "MAOKAI",
            "MASTERYI",
            "MISSFORTUNE",
            "MORDEKAISER",
            "MORGANA",
            "NAMI",
            "NASUS",
            "NAUTILUS",
            "NIDALEE",
            "NOCTURNE",
            "NUNU",
            "OLAF",
            "ORIANNA",
            "PANTHEON",
            "POPPY",
            "QUINN",
            "REKSAI",
            "RAMMUS",
            "RENEKTON",
            "RENGAR",
            "RIVEN",
            "RUMBLE",
            "RYZE",
            "SEJUANI",
            "SHACO",
            "SHEN",
            "SHYVANA",
            "SINGED",
            "SION",
            "SIVIR",
            "SKARNER",
            "SONA",
            "SORAKA",
            "SWAIN",
            "SYNDRA",
            "TALON",
            "TARIC",
            "TEEMO",
            "THRESH",
            "TRISTANA",
            "TRUNDLE",
            "TRYNDAMERE",
            "TWISTEDFATE",
            "TWITCH",
            "UDYR",
            "URGOT",
            "VARUS",
            "VAYNE",
            "VEIGAR",
            "VELKOZ",
            "VI",
            "VIKTOR",
            "VLADIMIR",
            "VOLIBEAR",
            "WARWICK",
            "WUKONG",
            "XERATH",
            "XINZHAO",
            "YASUO",
            "YORICK",
            "ZAC",
            "ZED",
            "ZIGGS",
            "ZILEAN",
            "ZYRA"});
            this.DefaultChampionInput.Location = new System.Drawing.Point(3, 185);
            this.DefaultChampionInput.Name = "DefaultChampionInput";
            this.DefaultChampionInput.Size = new System.Drawing.Size(312, 21);
            this.DefaultChampionInput.TabIndex = 15;
            this.DefaultChampionInput.Text = "BLITZCRANK";
            // 
            // defaultChampionLabel
            // 
            this.defaultChampionLabel.AutoSize = true;
            this.defaultChampionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultChampionLabel.Location = new System.Drawing.Point(3, 172);
            this.defaultChampionLabel.Name = "defaultChampionLabel";
            this.defaultChampionLabel.Size = new System.Drawing.Size(88, 13);
            this.defaultChampionLabel.TabIndex = 14;
            this.defaultChampionLabel.Text = "Tướng mặc định ";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(9, 516);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 52);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Lưu thay đổi config";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // BuyBoostInput
            // 
            this.BuyBoostInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyBoostInput.FormattingEnabled = true;
            this.BuyBoostInput.Items.AddRange(new object[] {
            "false",
            "Need Price 3 win ip boost / regions"});
            this.BuyBoostInput.Location = new System.Drawing.Point(3, 151);
            this.BuyBoostInput.Name = "BuyBoostInput";
            this.BuyBoostInput.Size = new System.Drawing.Size(312, 21);
            this.BuyBoostInput.TabIndex = 11;
            this.BuyBoostInput.Text = "false";
            // 
            // BuyBoostLabel
            // 
            this.BuyBoostLabel.AutoSize = true;
            this.BuyBoostLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyBoostLabel.Location = new System.Drawing.Point(3, 138);
            this.BuyBoostLabel.Name = "BuyBoostLabel";
            this.BuyBoostLabel.Size = new System.Drawing.Size(78, 13);
            this.BuyBoostLabel.TabIndex = 10;
            this.BuyBoostLabel.Text = "Buy XP Boost?";
            // 
            // Spell2Input
            // 
            this.Spell2Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spell2Input.FormattingEnabled = true;
            this.Spell2Input.Items.AddRange(new object[] {
            "BARRIER",
            "CLAIRVOYANCE",
            "CLARITY",
            "CLEANSE",
            "EXHAUST",
            "FLASH",
            "GARRISON",
            "GHOST",
            "HEAL",
            "IGNITE",
            "REVIVE",
            "SMITE",
            "TELEPORT"});
            this.Spell2Input.Location = new System.Drawing.Point(3, 117);
            this.Spell2Input.Name = "Spell2Input";
            this.Spell2Input.Size = new System.Drawing.Size(312, 21);
            this.Spell2Input.TabIndex = 9;
            this.Spell2Input.Text = "HEAL";
            // 
            // spell2Label
            // 
            this.spell2Label.AutoSize = true;
            this.spell2Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.spell2Label.Location = new System.Drawing.Point(3, 104);
            this.spell2Label.Name = "spell2Label";
            this.spell2Label.Size = new System.Drawing.Size(89, 13);
            this.spell2Label.TabIndex = 8;
            this.spell2Label.Text = "Phép bổ trợ 2  (F)";
            // 
            // Spell1Input
            // 
            this.Spell1Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spell1Input.FormattingEnabled = true;
            this.Spell1Input.Items.AddRange(new object[] {
            "BARRIER",
            "CLAIRVOYANCE",
            "CLARITY",
            "CLEANSE",
            "EXHAUST",
            "FLASH",
            "GARRISON",
            "GHOST",
            "HEAL",
            "IGNITE",
            "REVIVE",
            "SMITE",
            "TELEPORT"});
            this.Spell1Input.Location = new System.Drawing.Point(3, 83);
            this.Spell1Input.Name = "Spell1Input";
            this.Spell1Input.Size = new System.Drawing.Size(312, 21);
            this.Spell1Input.TabIndex = 7;
            this.Spell1Input.Text = "FLASH";
            // 
            // spell1Label
            // 
            this.spell1Label.AutoSize = true;
            this.spell1Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.spell1Label.Location = new System.Drawing.Point(3, 70);
            this.spell1Label.Name = "spell1Label";
            this.spell1Label.Size = new System.Drawing.Size(88, 13);
            this.spell1Label.TabIndex = 6;
            this.spell1Label.Text = "Phép bổ trợ 1 (D)";
            // 
            // RegionInput
            // 
            this.RegionInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegionInput.FormattingEnabled = true;
            this.RegionInput.Items.AddRange(new object[] {
            "TH",
            "SGMY",
            "VN",
            "PH",
            "TW"});
            this.RegionInput.Location = new System.Drawing.Point(3, 49);
            this.RegionInput.Name = "RegionInput";
            this.RegionInput.Size = new System.Drawing.Size(312, 21);
            this.RegionInput.TabIndex = 5;
            this.RegionInput.Text = "VN";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regionLabel.Location = new System.Drawing.Point(3, 36);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(41, 13);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Region";
            // 
            // LauncherPathInput
            // 
            this.LauncherPathInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.LauncherPathInput.Location = new System.Drawing.Point(3, 16);
            this.LauncherPathInput.Name = "LauncherPathInput";
            this.LauncherPathInput.Size = new System.Drawing.Size(312, 20);
            this.LauncherPathInput.TabIndex = 3;
            // 
            // launcherPathLabel
            // 
            this.launcherPathLabel.AutoSize = true;
            this.launcherPathLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.launcherPathLabel.Location = new System.Drawing.Point(3, 3);
            this.launcherPathLabel.Name = "launcherPathLabel";
            this.launcherPathLabel.Size = new System.Drawing.Size(144, 13);
            this.launcherPathLabel.TabIndex = 2;
            this.launcherPathLabel.Text = "Đường dẫn đên folder lol.exe";
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.DetectUrls = false;
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.ForeColor = System.Drawing.Color.Lime;
            this.console.ImeMode = System.Windows.Forms.ImeMode.On;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(654, 602);
            this.console.TabIndex = 0;
            this.console.Text = "";
            // 
            // frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.mainWindowSplitContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RitoBot GUI";
            this.Load += new System.EventHandler(this.frm_MainWindow_Load);
            this.mainWindowSplitContainer.Panel1.ResumeLayout(false);
            this.mainWindowSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).EndInit();
            this.mainWindowSplitContainer.ResumeLayout(false);
            this.configTabControl.ResumeLayout(false);
            this.accountsTab.ResumeLayout(false);
            this.accountsTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainWindowSplitContainer;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.TabControl configTabControl;
        private System.Windows.Forms.TabPage accountsTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button addAccountsBtn;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox newUserNameInput;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ComboBox QueueTypeInput;
        private System.Windows.Forms.Label QueueTypeLabel;
        private System.Windows.Forms.TextBox LauncherPathInput;
        private System.Windows.Forms.Label launcherPathLabel;
        private System.Windows.Forms.ComboBox RegionInput;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox BuyBoostInput;
        private System.Windows.Forms.Label BuyBoostLabel;
        private System.Windows.Forms.ComboBox Spell2Input;
        private System.Windows.Forms.Label spell2Label;
        private System.Windows.Forms.ComboBox Spell1Input;
        private System.Windows.Forms.Label spell1Label;
        private System.Windows.Forms.RichTextBox LoadedAccounts;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.TextBox MaxLevelInput;
        private System.Windows.Forms.TextBox MaxBotsInput;
        private System.Windows.Forms.Label maxBotsLabel;
        private System.Windows.Forms.ComboBox DefaultChampionInput;
        private System.Windows.Forms.Label defaultChampionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxLevelLabel;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_an_lol;
        public System.Windows.Forms.TextBox input_solanchoi;
    }
}

