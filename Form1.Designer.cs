namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createLobbyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summoner2 = new System.Windows.Forms.ComboBox();
            this.summoner2diff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.summoner3diff = new System.Windows.Forms.ComboBox();
            this.summoner3 = new System.Windows.Forms.ComboBox();
            this.summoner4diff = new System.Windows.Forms.ComboBox();
            this.summoner4 = new System.Windows.Forms.ComboBox();
            this.summoner5diff = new System.Windows.Forms.ComboBox();
            this.summoner5 = new System.Windows.Forms.ComboBox();
            this.summoner10diff = new System.Windows.Forms.ComboBox();
            this.summoner9diff = new System.Windows.Forms.ComboBox();
            this.summoner8diff = new System.Windows.Forms.ComboBox();
            this.summoner7diff = new System.Windows.Forms.ComboBox();
            this.summoner10 = new System.Windows.Forms.ComboBox();
            this.summoner9 = new System.Windows.Forms.ComboBox();
            this.summoner8 = new System.Windows.Forms.ComboBox();
            this.summoner7 = new System.Windows.Forms.ComboBox();
            this.summoner6 = new System.Windows.Forms.ComboBox();
            this.summoner6diff = new System.Windows.Forms.ComboBox();
            this.saveLayout = new System.Windows.Forms.CheckBox();
            this.summoner6lane = new System.Windows.Forms.ComboBox();
            this.summoner10lane = new System.Windows.Forms.ComboBox();
            this.summoner9lane = new System.Windows.Forms.ComboBox();
            this.summoner8lane = new System.Windows.Forms.ComboBox();
            this.summoner7lane = new System.Windows.Forms.ComboBox();
            this.summoner5lane = new System.Windows.Forms.ComboBox();
            this.summoner4lane = new System.Windows.Forms.ComboBox();
            this.summoner3lane = new System.Windows.Forms.ComboBox();
            this.summoner2lane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lobbyPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lobbyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetLayout = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createLobbyBtn
            // 
            this.createLobbyBtn.Location = new System.Drawing.Point(360, 336);
            this.createLobbyBtn.Name = "createLobbyBtn";
            this.createLobbyBtn.Size = new System.Drawing.Size(160, 42);
            this.createLobbyBtn.TabIndex = 0;
            this.createLobbyBtn.Text = "Create";
            this.createLobbyBtn.UseVisualStyleBackColor = true;
            this.createLobbyBtn.Click += new System.EventHandler(this.createLobbyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blue Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(711, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Red Team";
            // 
            // summoner2
            // 
            this.summoner2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.summoner2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner2.FormattingEnabled = true;
            this.summoner2.Location = new System.Drawing.Point(39, 160);
            this.summoner2.Name = "summoner2";
            this.summoner2.Size = new System.Drawing.Size(206, 24);
            this.summoner2.TabIndex = 3;
            this.summoner2.Text = "Pick a champion...";
            // 
            // summoner2diff
            // 
            this.summoner2diff.FormattingEnabled = true;
            this.summoner2diff.Location = new System.Drawing.Point(264, 160);
            this.summoner2diff.Name = "summoner2diff";
            this.summoner2diff.Size = new System.Drawing.Size(54, 24);
            this.summoner2diff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "You";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(39, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 10);
            this.label4.TabIndex = 6;
            // 
            // summoner3diff
            // 
            this.summoner3diff.FormattingEnabled = true;
            this.summoner3diff.Location = new System.Drawing.Point(264, 200);
            this.summoner3diff.Name = "summoner3diff";
            this.summoner3diff.Size = new System.Drawing.Size(54, 24);
            this.summoner3diff.TabIndex = 8;
            // 
            // summoner3
            // 
            this.summoner3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner3.FormattingEnabled = true;
            this.summoner3.Location = new System.Drawing.Point(38, 200);
            this.summoner3.Name = "summoner3";
            this.summoner3.Size = new System.Drawing.Size(206, 24);
            this.summoner3.TabIndex = 7;
            this.summoner3.Text = "Pick a champion...";
            // 
            // summoner4diff
            // 
            this.summoner4diff.FormattingEnabled = true;
            this.summoner4diff.Location = new System.Drawing.Point(264, 240);
            this.summoner4diff.Name = "summoner4diff";
            this.summoner4diff.Size = new System.Drawing.Size(54, 24);
            this.summoner4diff.TabIndex = 10;
            // 
            // summoner4
            // 
            this.summoner4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner4.FormattingEnabled = true;
            this.summoner4.Location = new System.Drawing.Point(39, 240);
            this.summoner4.Name = "summoner4";
            this.summoner4.Size = new System.Drawing.Size(206, 24);
            this.summoner4.TabIndex = 9;
            this.summoner4.Text = "Pick a champion...";
            // 
            // summoner5diff
            // 
            this.summoner5diff.FormattingEnabled = true;
            this.summoner5diff.Location = new System.Drawing.Point(264, 280);
            this.summoner5diff.Name = "summoner5diff";
            this.summoner5diff.Size = new System.Drawing.Size(54, 24);
            this.summoner5diff.TabIndex = 12;
            // 
            // summoner5
            // 
            this.summoner5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner5.FormattingEnabled = true;
            this.summoner5.Location = new System.Drawing.Point(39, 280);
            this.summoner5.Name = "summoner5";
            this.summoner5.Size = new System.Drawing.Size(206, 24);
            this.summoner5.TabIndex = 11;
            this.summoner5.Text = "Pick a champion...";
            // 
            // summoner10diff
            // 
            this.summoner10diff.FormattingEnabled = true;
            this.summoner10diff.Location = new System.Drawing.Point(544, 280);
            this.summoner10diff.Name = "summoner10diff";
            this.summoner10diff.Size = new System.Drawing.Size(54, 24);
            this.summoner10diff.TabIndex = 16;
            // 
            // summoner9diff
            // 
            this.summoner9diff.FormattingEnabled = true;
            this.summoner9diff.Location = new System.Drawing.Point(544, 240);
            this.summoner9diff.Name = "summoner9diff";
            this.summoner9diff.Size = new System.Drawing.Size(54, 24);
            this.summoner9diff.TabIndex = 15;
            // 
            // summoner8diff
            // 
            this.summoner8diff.FormattingEnabled = true;
            this.summoner8diff.Location = new System.Drawing.Point(544, 200);
            this.summoner8diff.Name = "summoner8diff";
            this.summoner8diff.Size = new System.Drawing.Size(54, 24);
            this.summoner8diff.TabIndex = 14;
            // 
            // summoner7diff
            // 
            this.summoner7diff.FormattingEnabled = true;
            this.summoner7diff.Location = new System.Drawing.Point(544, 160);
            this.summoner7diff.Name = "summoner7diff";
            this.summoner7diff.Size = new System.Drawing.Size(54, 24);
            this.summoner7diff.TabIndex = 13;
            // 
            // summoner10
            // 
            this.summoner10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner10.FormattingEnabled = true;
            this.summoner10.Location = new System.Drawing.Point(616, 280);
            this.summoner10.Name = "summoner10";
            this.summoner10.Size = new System.Drawing.Size(206, 24);
            this.summoner10.TabIndex = 20;
            this.summoner10.Text = "Pick a champion...";
            // 
            // summoner9
            // 
            this.summoner9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner9.FormattingEnabled = true;
            this.summoner9.Location = new System.Drawing.Point(616, 240);
            this.summoner9.Name = "summoner9";
            this.summoner9.Size = new System.Drawing.Size(206, 24);
            this.summoner9.TabIndex = 19;
            this.summoner9.Text = "Pick a champion...";
            // 
            // summoner8
            // 
            this.summoner8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner8.FormattingEnabled = true;
            this.summoner8.Location = new System.Drawing.Point(615, 200);
            this.summoner8.Name = "summoner8";
            this.summoner8.Size = new System.Drawing.Size(206, 24);
            this.summoner8.TabIndex = 18;
            this.summoner8.Text = "Pick a champion...";
            // 
            // summoner7
            // 
            this.summoner7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner7.FormattingEnabled = true;
            this.summoner7.Location = new System.Drawing.Point(616, 160);
            this.summoner7.Name = "summoner7";
            this.summoner7.Size = new System.Drawing.Size(206, 24);
            this.summoner7.TabIndex = 17;
            this.summoner7.Text = "Pick a champion...";
            // 
            // summoner6
            // 
            this.summoner6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.summoner6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.summoner6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.summoner6.FormattingEnabled = true;
            this.summoner6.Location = new System.Drawing.Point(615, 116);
            this.summoner6.Name = "summoner6";
            this.summoner6.Size = new System.Drawing.Size(206, 24);
            this.summoner6.TabIndex = 22;
            this.summoner6.Text = "Pick a champion...";
            // 
            // summoner6diff
            // 
            this.summoner6diff.FormattingEnabled = true;
            this.summoner6diff.Location = new System.Drawing.Point(544, 116);
            this.summoner6diff.Name = "summoner6diff";
            this.summoner6diff.Size = new System.Drawing.Size(54, 24);
            this.summoner6diff.TabIndex = 21;
            // 
            // saveLayout
            // 
            this.saveLayout.AutoSize = true;
            this.saveLayout.Location = new System.Drawing.Point(577, 320);
            this.saveLayout.Name = "saveLayout";
            this.saveLayout.Size = new System.Drawing.Size(123, 20);
            this.saveLayout.TabIndex = 23;
            this.saveLayout.Text = "Save this layout";
            this.saveLayout.UseVisualStyleBackColor = true;
            // 
            // summoner6lane
            // 
            this.summoner6lane.FormattingEnabled = true;
            this.summoner6lane.Location = new System.Drawing.Point(484, 116);
            this.summoner6lane.Name = "summoner6lane";
            this.summoner6lane.Size = new System.Drawing.Size(54, 24);
            this.summoner6lane.TabIndex = 28;
            // 
            // summoner10lane
            // 
            this.summoner10lane.FormattingEnabled = true;
            this.summoner10lane.Location = new System.Drawing.Point(484, 280);
            this.summoner10lane.Name = "summoner10lane";
            this.summoner10lane.Size = new System.Drawing.Size(54, 24);
            this.summoner10lane.TabIndex = 27;
            // 
            // summoner9lane
            // 
            this.summoner9lane.FormattingEnabled = true;
            this.summoner9lane.Location = new System.Drawing.Point(484, 240);
            this.summoner9lane.Name = "summoner9lane";
            this.summoner9lane.Size = new System.Drawing.Size(54, 24);
            this.summoner9lane.TabIndex = 26;
            // 
            // summoner8lane
            // 
            this.summoner8lane.FormattingEnabled = true;
            this.summoner8lane.Location = new System.Drawing.Point(484, 200);
            this.summoner8lane.Name = "summoner8lane";
            this.summoner8lane.Size = new System.Drawing.Size(54, 24);
            this.summoner8lane.TabIndex = 25;
            // 
            // summoner7lane
            // 
            this.summoner7lane.FormattingEnabled = true;
            this.summoner7lane.Location = new System.Drawing.Point(484, 160);
            this.summoner7lane.Name = "summoner7lane";
            this.summoner7lane.Size = new System.Drawing.Size(54, 24);
            this.summoner7lane.TabIndex = 24;
            // 
            // summoner5lane
            // 
            this.summoner5lane.FormattingEnabled = true;
            this.summoner5lane.Location = new System.Drawing.Point(324, 280);
            this.summoner5lane.Name = "summoner5lane";
            this.summoner5lane.Size = new System.Drawing.Size(54, 24);
            this.summoner5lane.TabIndex = 32;
            // 
            // summoner4lane
            // 
            this.summoner4lane.FormattingEnabled = true;
            this.summoner4lane.Location = new System.Drawing.Point(324, 240);
            this.summoner4lane.Name = "summoner4lane";
            this.summoner4lane.Size = new System.Drawing.Size(54, 24);
            this.summoner4lane.TabIndex = 31;
            // 
            // summoner3lane
            // 
            this.summoner3lane.FormattingEnabled = true;
            this.summoner3lane.Location = new System.Drawing.Point(324, 200);
            this.summoner3lane.Name = "summoner3lane";
            this.summoner3lane.Size = new System.Drawing.Size(54, 24);
            this.summoner3lane.TabIndex = 30;
            // 
            // summoner2lane
            // 
            this.summoner2lane.FormattingEnabled = true;
            this.summoner2lane.Location = new System.Drawing.Point(324, 160);
            this.summoner2lane.Name = "summoner2lane";
            this.summoner2lane.Size = new System.Drawing.Size(54, 24);
            this.summoner2lane.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(206, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nanolobby - 5v5 Training Lobby Creator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(473, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "credits to kaan1957 on\r\n";
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.AutoSize = true;
            this.viewLogsBtn.Location = new System.Drawing.Point(707, 346);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(115, 26);
            this.viewLogsBtn.TabIndex = 36;
            this.viewLogsBtn.Text = "Show Error Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lobby Password:";
            // 
            // lobbyPwd
            // 
            this.lobbyPwd.Location = new System.Drawing.Point(155, 346);
            this.lobbyPwd.Name = "lobbyPwd";
            this.lobbyPwd.Size = new System.Drawing.Size(100, 22);
            this.lobbyPwd.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Lobby Name:";
            // 
            // lobbyName
            // 
            this.lobbyName.Location = new System.Drawing.Point(155, 318);
            this.lobbyName.Name = "lobbyName";
            this.lobbyName.Size = new System.Drawing.Size(100, 22);
            this.lobbyName.TabIndex = 38;
            this.lobbyName.Text = "Training 5v5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(750, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "TIPS: If you are going to add 5 bots to your lobby make sure they are all assigne" +
    "d to traditional positions or else the bots wont work and will stay on the fount" +
    "ain";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Lane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Difficulty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Lane";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(544, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Difficulty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.marlboro_ice_blast_by_cb3723_d67rhik_414w_2x;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // resetLayout
            // 
            this.resetLayout.Location = new System.Drawing.Point(706, 319);
            this.resetLayout.Name = "resetLayout";
            this.resetLayout.Size = new System.Drawing.Size(115, 23);
            this.resetLayout.TabIndex = 44;
            this.resetLayout.Text = "Reset Layout";
            this.resetLayout.UseVisualStyleBackColor = true;
            this.resetLayout.Click += new System.EventHandler(this.resetLayout_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(12, 420);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(435, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Do not use duplicate roles you can\'t choose 2 midlaners at the same time lobby wo" +
    "n\'t create";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(585, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.createLobbyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 453);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.resetLayout);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lobbyName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lobbyPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viewLogsBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.summoner5lane);
            this.Controls.Add(this.summoner4lane);
            this.Controls.Add(this.summoner3lane);
            this.Controls.Add(this.summoner2lane);
            this.Controls.Add(this.summoner6lane);
            this.Controls.Add(this.summoner10lane);
            this.Controls.Add(this.summoner9lane);
            this.Controls.Add(this.summoner8lane);
            this.Controls.Add(this.summoner7lane);
            this.Controls.Add(this.saveLayout);
            this.Controls.Add(this.summoner6);
            this.Controls.Add(this.summoner6diff);
            this.Controls.Add(this.summoner10);
            this.Controls.Add(this.summoner9);
            this.Controls.Add(this.summoner8);
            this.Controls.Add(this.summoner7);
            this.Controls.Add(this.summoner10diff);
            this.Controls.Add(this.summoner9diff);
            this.Controls.Add(this.summoner8diff);
            this.Controls.Add(this.summoner7diff);
            this.Controls.Add(this.summoner5diff);
            this.Controls.Add(this.summoner5);
            this.Controls.Add(this.summoner4diff);
            this.Controls.Add(this.summoner4);
            this.Controls.Add(this.summoner3diff);
            this.Controls.Add(this.summoner3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.summoner2diff);
            this.Controls.Add(this.summoner2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createLobbyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(869, 500);
            this.MinimumSize = new System.Drawing.Size(869, 500);
            this.Name = "Form1";
            this.Text = "Nanolobby - League 5v5 Training Lobby Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLobbyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox summoner2;
        private System.Windows.Forms.ComboBox summoner2diff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox summoner3diff;
        private System.Windows.Forms.ComboBox summoner3;
        private System.Windows.Forms.ComboBox summoner4diff;
        private System.Windows.Forms.ComboBox summoner4;
        private System.Windows.Forms.ComboBox summoner5diff;
        private System.Windows.Forms.ComboBox summoner5;
        private System.Windows.Forms.ComboBox summoner10diff;
        private System.Windows.Forms.ComboBox summoner9diff;
        private System.Windows.Forms.ComboBox summoner8diff;
        private System.Windows.Forms.ComboBox summoner7diff;
        private System.Windows.Forms.ComboBox summoner10;
        private System.Windows.Forms.ComboBox summoner9;
        private System.Windows.Forms.ComboBox summoner8;
        private System.Windows.Forms.ComboBox summoner7;
        private System.Windows.Forms.ComboBox summoner6;
        private System.Windows.Forms.ComboBox summoner6diff;
        private System.Windows.Forms.CheckBox saveLayout;
        private System.Windows.Forms.ComboBox summoner6lane;
        private System.Windows.Forms.ComboBox summoner10lane;
        private System.Windows.Forms.ComboBox summoner9lane;
        private System.Windows.Forms.ComboBox summoner8lane;
        private System.Windows.Forms.ComboBox summoner7lane;
        private System.Windows.Forms.ComboBox summoner5lane;
        private System.Windows.Forms.ComboBox summoner4lane;
        private System.Windows.Forms.ComboBox summoner3lane;
        private System.Windows.Forms.ComboBox summoner2lane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lobbyPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lobbyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button resetLayout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

