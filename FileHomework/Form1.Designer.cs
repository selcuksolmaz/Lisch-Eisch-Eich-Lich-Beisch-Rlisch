namespace FileHomework
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
            this.lstbRandomNumber = new System.Windows.Forms.ListBox();
            this.gbRandomNumber = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPercentage = new System.Windows.Forms.ComboBox();
            this.txtbCreateRandom = new System.Windows.Forms.TextBox();
            this.btnCreateRandom = new System.Windows.Forms.Button();
            this.lstbLisch = new System.Windows.Forms.ListBox();
            this.lstbEisch = new System.Windows.Forms.ListBox();
            this.lstbLich = new System.Windows.Forms.ListBox();
            this.lstbEich = new System.Windows.Forms.ListBox();
            this.lstbBeisch = new System.Windows.Forms.ListBox();
            this.lstbRlisch = new System.Windows.Forms.ListBox();
            this.lblLısch = new System.Windows.Forms.Label();
            this.lblEısch = new System.Windows.Forms.Label();
            this.lblLıch = new System.Windows.Forms.Label();
            this.lblEıch = new System.Windows.Forms.Label();
            this.lblBeisch = new System.Windows.Forms.Label();
            this.lblRlisch = new System.Windows.Forms.Label();
            this.bynSearch = new System.Windows.Forms.Button();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPackingFactor = new System.Windows.Forms.Label();
            this.lblTotalMemory = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblPFLisch = new System.Windows.Forms.Label();
            this.lblPFEisch = new System.Windows.Forms.Label();
            this.lblPFLich = new System.Windows.Forms.Label();
            this.lblPFEich = new System.Windows.Forms.Label();
            this.lblPFBeisch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAPRlisch = new System.Windows.Forms.Label();
            this.lblAPBeisch = new System.Windows.Forms.Label();
            this.lblAPEich = new System.Windows.Forms.Label();
            this.lblAPLich = new System.Windows.Forms.Label();
            this.lblAPEisch = new System.Windows.Forms.Label();
            this.lblAPLisch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTRRlisch = new System.Windows.Forms.Label();
            this.lblTMRlisch = new System.Windows.Forms.Label();
            this.lblTRBeisch = new System.Windows.Forms.Label();
            this.lblTMBeisch = new System.Windows.Forms.Label();
            this.lblTREich = new System.Windows.Forms.Label();
            this.lblTMEich = new System.Windows.Forms.Label();
            this.lblTRLich = new System.Windows.Forms.Label();
            this.lblTMLich = new System.Windows.Forms.Label();
            this.lblTREisch = new System.Windows.Forms.Label();
            this.lblTMEisch = new System.Windows.Forms.Label();
            this.lblTRLisch = new System.Windows.Forms.Label();
            this.lblTMLisch = new System.Windows.Forms.Label();
            this.lblPFRlisch = new System.Windows.Forms.Label();
            this.lblSIRlisch = new System.Windows.Forms.Label();
            this.lblSIBeisch = new System.Windows.Forms.Label();
            this.lblSIEich = new System.Windows.Forms.Label();
            this.lblSILich = new System.Windows.Forms.Label();
            this.lblSIEisch = new System.Windows.Forms.Label();
            this.lblSILisch = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbRandomNumber.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbRandomNumber
            // 
            this.lstbRandomNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbRandomNumber.FormattingEnabled = true;
            this.lstbRandomNumber.ItemHeight = 19;
            this.lstbRandomNumber.Location = new System.Drawing.Point(8, 23);
            this.lstbRandomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lstbRandomNumber.Name = "lstbRandomNumber";
            this.lstbRandomNumber.Size = new System.Drawing.Size(240, 232);
            this.lstbRandomNumber.TabIndex = 0;
            // 
            // gbRandomNumber
            // 
            this.gbRandomNumber.Controls.Add(this.label8);
            this.gbRandomNumber.Controls.Add(this.label7);
            this.gbRandomNumber.Controls.Add(this.cmbPercentage);
            this.gbRandomNumber.Controls.Add(this.txtbCreateRandom);
            this.gbRandomNumber.Controls.Add(this.btnCreateRandom);
            this.gbRandomNumber.Controls.Add(this.lstbRandomNumber);
            this.gbRandomNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbRandomNumber.Location = new System.Drawing.Point(16, 15);
            this.gbRandomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.gbRandomNumber.Name = "gbRandomNumber";
            this.gbRandomNumber.Padding = new System.Windows.Forms.Padding(4);
            this.gbRandomNumber.Size = new System.Drawing.Size(423, 274);
            this.gbRandomNumber.TabIndex = 1;
            this.gbRandomNumber.TabStop = false;
            this.gbRandomNumber.Text = "Random Number";
            this.gbRandomNumber.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(257, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "%";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(257, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "For Lich and Eich ";
            // 
            // cmbPercentage
            // 
            this.cmbPercentage.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPercentage.FormattingEnabled = true;
            this.cmbPercentage.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.cmbPercentage.Location = new System.Drawing.Point(283, 139);
            this.cmbPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPercentage.Name = "cmbPercentage";
            this.cmbPercentage.Size = new System.Drawing.Size(131, 27);
            this.cmbPercentage.TabIndex = 3;
            this.cmbPercentage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbCreateRandom
            // 
            this.txtbCreateRandom.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbCreateRandom.Location = new System.Drawing.Point(257, 53);
            this.txtbCreateRandom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbCreateRandom.Name = "txtbCreateRandom";
            this.txtbCreateRandom.Size = new System.Drawing.Size(132, 27);
            this.txtbCreateRandom.TabIndex = 2;
            // 
            // btnCreateRandom
            // 
            this.btnCreateRandom.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateRandom.Location = new System.Drawing.Point(257, 92);
            this.btnCreateRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRandom.Name = "btnCreateRandom";
            this.btnCreateRandom.Size = new System.Drawing.Size(133, 36);
            this.btnCreateRandom.TabIndex = 1;
            this.btnCreateRandom.Text = "Create Table";
            this.btnCreateRandom.UseVisualStyleBackColor = true;
            this.btnCreateRandom.Click += new System.EventHandler(this.btnCreateRandom_Click);
            // 
            // lstbLisch
            // 
            this.lstbLisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbLisch.FormattingEnabled = true;
            this.lstbLisch.ItemHeight = 19;
            this.lstbLisch.Location = new System.Drawing.Point(4, 350);
            this.lstbLisch.Margin = new System.Windows.Forms.Padding(4);
            this.lstbLisch.Name = "lstbLisch";
            this.lstbLisch.Size = new System.Drawing.Size(193, 289);
            this.lstbLisch.TabIndex = 3;
            // 
            // lstbEisch
            // 
            this.lstbEisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbEisch.FormattingEnabled = true;
            this.lstbEisch.ItemHeight = 19;
            this.lstbEisch.Location = new System.Drawing.Point(208, 350);
            this.lstbEisch.Margin = new System.Windows.Forms.Padding(4);
            this.lstbEisch.Name = "lstbEisch";
            this.lstbEisch.Size = new System.Drawing.Size(193, 289);
            this.lstbEisch.TabIndex = 4;
            this.lstbEisch.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lstbLich
            // 
            this.lstbLich.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbLich.FormattingEnabled = true;
            this.lstbLich.ItemHeight = 19;
            this.lstbLich.Location = new System.Drawing.Point(412, 350);
            this.lstbLich.Margin = new System.Windows.Forms.Padding(4);
            this.lstbLich.Name = "lstbLich";
            this.lstbLich.Size = new System.Drawing.Size(193, 289);
            this.lstbLich.TabIndex = 5;
            // 
            // lstbEich
            // 
            this.lstbEich.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbEich.FormattingEnabled = true;
            this.lstbEich.ItemHeight = 19;
            this.lstbEich.Location = new System.Drawing.Point(616, 350);
            this.lstbEich.Margin = new System.Windows.Forms.Padding(4);
            this.lstbEich.Name = "lstbEich";
            this.lstbEich.Size = new System.Drawing.Size(193, 289);
            this.lstbEich.TabIndex = 6;
            this.lstbEich.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // lstbBeisch
            // 
            this.lstbBeisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbBeisch.FormattingEnabled = true;
            this.lstbBeisch.ItemHeight = 19;
            this.lstbBeisch.Location = new System.Drawing.Point(820, 350);
            this.lstbBeisch.Margin = new System.Windows.Forms.Padding(4);
            this.lstbBeisch.Name = "lstbBeisch";
            this.lstbBeisch.Size = new System.Drawing.Size(193, 289);
            this.lstbBeisch.TabIndex = 7;
            // 
            // lstbRlisch
            // 
            this.lstbRlisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbRlisch.FormattingEnabled = true;
            this.lstbRlisch.ItemHeight = 19;
            this.lstbRlisch.Location = new System.Drawing.Point(1024, 350);
            this.lstbRlisch.Margin = new System.Windows.Forms.Padding(4);
            this.lstbRlisch.Name = "lstbRlisch";
            this.lstbRlisch.Size = new System.Drawing.Size(193, 289);
            this.lstbRlisch.TabIndex = 8;
            // 
            // lblLısch
            // 
            this.lblLısch.AutoSize = true;
            this.lblLısch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLısch.Location = new System.Drawing.Point(59, 314);
            this.lblLısch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLısch.Name = "lblLısch";
            this.lblLısch.Size = new System.Drawing.Size(46, 24);
            this.lblLısch.TabIndex = 9;
            this.lblLısch.Text = "LISCH";
            // 
            // lblEısch
            // 
            this.lblEısch.AutoSize = true;
            this.lblEısch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEısch.Location = new System.Drawing.Point(263, 314);
            this.lblEısch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEısch.Name = "lblEısch";
            this.lblEısch.Size = new System.Drawing.Size(47, 24);
            this.lblEısch.TabIndex = 10;
            this.lblEısch.Text = "EISCH";
            // 
            // lblLıch
            // 
            this.lblLıch.AutoSize = true;
            this.lblLıch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLıch.Location = new System.Drawing.Point(467, 314);
            this.lblLıch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLıch.Name = "lblLıch";
            this.lblLıch.Size = new System.Drawing.Size(37, 24);
            this.lblLıch.TabIndex = 11;
            this.lblLıch.Text = "LICH";
            // 
            // lblEıch
            // 
            this.lblEıch.AutoSize = true;
            this.lblEıch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEıch.Location = new System.Drawing.Point(671, 314);
            this.lblEıch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEıch.Name = "lblEıch";
            this.lblEıch.Size = new System.Drawing.Size(38, 24);
            this.lblEıch.TabIndex = 12;
            this.lblEıch.Text = "EICH";
            // 
            // lblBeisch
            // 
            this.lblBeisch.AutoSize = true;
            this.lblBeisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeisch.Location = new System.Drawing.Point(883, 314);
            this.lblBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeisch.Name = "lblBeisch";
            this.lblBeisch.Size = new System.Drawing.Size(55, 24);
            this.lblBeisch.TabIndex = 13;
            this.lblBeisch.Text = "BEISCH";
            // 
            // lblRlisch
            // 
            this.lblRlisch.AutoSize = true;
            this.lblRlisch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRlisch.Location = new System.Drawing.Point(1095, 314);
            this.lblRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRlisch.Name = "lblRlisch";
            this.lblRlisch.Size = new System.Drawing.Size(55, 24);
            this.lblRlisch.TabIndex = 14;
            this.lblRlisch.Text = "RLISCH";
            // 
            // bynSearch
            // 
            this.bynSearch.Location = new System.Drawing.Point(186, 24);
            this.bynSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bynSearch.Name = "bynSearch";
            this.bynSearch.Size = new System.Drawing.Size(133, 36);
            this.bynSearch.TabIndex = 1;
            this.bynSearch.Text = "Search";
            this.bynSearch.UseVisualStyleBackColor = true;
            this.bynSearch.Click += new System.EventHandler(this.bynSearch_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbSearch.Location = new System.Drawing.Point(27, 33);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(132, 27);
            this.txtbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(241, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "EISCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "LICH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(465, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "EICH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(573, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "BEISCH";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(700, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "RLISCH";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPackingFactor
            // 
            this.lblPackingFactor.AutoSize = true;
            this.lblPackingFactor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPackingFactor.Location = new System.Drawing.Point(-5, 133);
            this.lblPackingFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackingFactor.Name = "lblPackingFactor";
            this.lblPackingFactor.Size = new System.Drawing.Size(109, 24);
            this.lblPackingFactor.TabIndex = 9;
            this.lblPackingFactor.Text = "Packing Factor";
            // 
            // lblTotalMemory
            // 
            this.lblTotalMemory.AutoSize = true;
            this.lblTotalMemory.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMemory.Location = new System.Drawing.Point(-5, 170);
            this.lblTotalMemory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMemory.Name = "lblTotalMemory";
            this.lblTotalMemory.Size = new System.Drawing.Size(100, 24);
            this.lblTotalMemory.TabIndex = 10;
            this.lblTotalMemory.Text = "Total Memory";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalRecords.Location = new System.Drawing.Point(-5, 207);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(100, 24);
            this.lblTotalRecords.TabIndex = 11;
            this.lblTotalRecords.Text = "Total Records";
            // 
            // lblPFLisch
            // 
            this.lblPFLisch.AutoSize = true;
            this.lblPFLisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFLisch.Location = new System.Drawing.Point(125, 139);
            this.lblPFLisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFLisch.Name = "lblPFLisch";
            this.lblPFLisch.Size = new System.Drawing.Size(49, 21);
            this.lblPFLisch.TabIndex = 12;
            this.lblPFLisch.Text = "LISCH";
            // 
            // lblPFEisch
            // 
            this.lblPFEisch.AutoSize = true;
            this.lblPFEisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFEisch.Location = new System.Drawing.Point(240, 139);
            this.lblPFEisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFEisch.Name = "lblPFEisch";
            this.lblPFEisch.Size = new System.Drawing.Size(49, 21);
            this.lblPFEisch.TabIndex = 13;
            this.lblPFEisch.Text = "LISCH";
            // 
            // lblPFLich
            // 
            this.lblPFLich.AutoSize = true;
            this.lblPFLich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFLich.Location = new System.Drawing.Point(355, 139);
            this.lblPFLich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFLich.Name = "lblPFLich";
            this.lblPFLich.Size = new System.Drawing.Size(49, 21);
            this.lblPFLich.TabIndex = 14;
            this.lblPFLich.Text = "LISCH";
            // 
            // lblPFEich
            // 
            this.lblPFEich.AutoSize = true;
            this.lblPFEich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFEich.Location = new System.Drawing.Point(469, 139);
            this.lblPFEich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFEich.Name = "lblPFEich";
            this.lblPFEich.Size = new System.Drawing.Size(49, 21);
            this.lblPFEich.TabIndex = 15;
            this.lblPFEich.Text = "LISCH";
            // 
            // lblPFBeisch
            // 
            this.lblPFBeisch.AutoSize = true;
            this.lblPFBeisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFBeisch.Location = new System.Drawing.Point(584, 139);
            this.lblPFBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFBeisch.Name = "lblPFBeisch";
            this.lblPFBeisch.Size = new System.Drawing.Size(49, 21);
            this.lblPFBeisch.TabIndex = 16;
            this.lblPFBeisch.Text = "LISCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblSIRlisch);
            this.groupBox1.Controls.Add(this.lblSIBeisch);
            this.groupBox1.Controls.Add(this.lblSIEich);
            this.groupBox1.Controls.Add(this.lblSILich);
            this.groupBox1.Controls.Add(this.lblSIEisch);
            this.groupBox1.Controls.Add(this.lblSILisch);
            this.groupBox1.Controls.Add(this.lblAPRlisch);
            this.groupBox1.Controls.Add(this.lblAPBeisch);
            this.groupBox1.Controls.Add(this.lblAPEich);
            this.groupBox1.Controls.Add(this.lblAPLich);
            this.groupBox1.Controls.Add(this.lblAPEisch);
            this.groupBox1.Controls.Add(this.lblAPLisch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblTRRlisch);
            this.groupBox1.Controls.Add(this.lblTMRlisch);
            this.groupBox1.Controls.Add(this.lblTRBeisch);
            this.groupBox1.Controls.Add(this.lblTMBeisch);
            this.groupBox1.Controls.Add(this.lblTREich);
            this.groupBox1.Controls.Add(this.lblTMEich);
            this.groupBox1.Controls.Add(this.lblTRLich);
            this.groupBox1.Controls.Add(this.lblTMLich);
            this.groupBox1.Controls.Add(this.lblTREisch);
            this.groupBox1.Controls.Add(this.lblTMEisch);
            this.groupBox1.Controls.Add(this.lblTRLisch);
            this.groupBox1.Controls.Add(this.lblTMLisch);
            this.groupBox1.Controls.Add(this.lblPFRlisch);
            this.groupBox1.Controls.Add(this.lblPFBeisch);
            this.groupBox1.Controls.Add(this.lblPFEich);
            this.groupBox1.Controls.Add(this.lblPFLich);
            this.groupBox1.Controls.Add(this.lblPFEisch);
            this.groupBox1.Controls.Add(this.lblPFLisch);
            this.groupBox1.Controls.Add(this.lblTotalRecords);
            this.groupBox1.Controls.Add(this.lblTotalMemory);
            this.groupBox1.Controls.Add(this.lblPackingFactor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbSearch);
            this.groupBox1.Controls.Add(this.bynSearch);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(444, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(775, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and Performance";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblAPRlisch
            // 
            this.lblAPRlisch.AutoSize = true;
            this.lblAPRlisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPRlisch.Location = new System.Drawing.Point(701, 245);
            this.lblAPRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPRlisch.Name = "lblAPRlisch";
            this.lblAPRlisch.Size = new System.Drawing.Size(49, 21);
            this.lblAPRlisch.TabIndex = 36;
            this.lblAPRlisch.Text = "LISCH";
            // 
            // lblAPBeisch
            // 
            this.lblAPBeisch.AutoSize = true;
            this.lblAPBeisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPBeisch.Location = new System.Drawing.Point(584, 249);
            this.lblAPBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPBeisch.Name = "lblAPBeisch";
            this.lblAPBeisch.Size = new System.Drawing.Size(49, 21);
            this.lblAPBeisch.TabIndex = 35;
            this.lblAPBeisch.Text = "LISCH";
            // 
            // lblAPEich
            // 
            this.lblAPEich.AutoSize = true;
            this.lblAPEich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPEich.Location = new System.Drawing.Point(469, 249);
            this.lblAPEich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPEich.Name = "lblAPEich";
            this.lblAPEich.Size = new System.Drawing.Size(49, 21);
            this.lblAPEich.TabIndex = 34;
            this.lblAPEich.Text = "LISCH";
            // 
            // lblAPLich
            // 
            this.lblAPLich.AutoSize = true;
            this.lblAPLich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPLich.Location = new System.Drawing.Point(355, 249);
            this.lblAPLich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPLich.Name = "lblAPLich";
            this.lblAPLich.Size = new System.Drawing.Size(49, 21);
            this.lblAPLich.TabIndex = 33;
            this.lblAPLich.Text = "LISCH";
            this.lblAPLich.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblAPEisch
            // 
            this.lblAPEisch.AutoSize = true;
            this.lblAPEisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPEisch.Location = new System.Drawing.Point(240, 249);
            this.lblAPEisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPEisch.Name = "lblAPEisch";
            this.lblAPEisch.Size = new System.Drawing.Size(49, 21);
            this.lblAPEisch.TabIndex = 32;
            this.lblAPEisch.Text = "LISCH";
            // 
            // lblAPLisch
            // 
            this.lblAPLisch.AutoSize = true;
            this.lblAPLisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAPLisch.Location = new System.Drawing.Point(127, 249);
            this.lblAPLisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPLisch.Name = "lblAPLisch";
            this.lblAPLisch.Size = new System.Drawing.Size(49, 21);
            this.lblAPLisch.TabIndex = 31;
            this.lblAPLisch.Text = "LISCH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(-5, 245);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Average Probes";
            // 
            // lblTRRlisch
            // 
            this.lblTRRlisch.AutoSize = true;
            this.lblTRRlisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRRlisch.Location = new System.Drawing.Point(701, 210);
            this.lblTRRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTRRlisch.Name = "lblTRRlisch";
            this.lblTRRlisch.Size = new System.Drawing.Size(49, 21);
            this.lblTRRlisch.TabIndex = 29;
            this.lblTRRlisch.Text = "LISCH";
            // 
            // lblTMRlisch
            // 
            this.lblTMRlisch.AutoSize = true;
            this.lblTMRlisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMRlisch.Location = new System.Drawing.Point(699, 175);
            this.lblTMRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMRlisch.Name = "lblTMRlisch";
            this.lblTMRlisch.Size = new System.Drawing.Size(49, 21);
            this.lblTMRlisch.TabIndex = 28;
            this.lblTMRlisch.Text = "LISCH";
            // 
            // lblTRBeisch
            // 
            this.lblTRBeisch.AutoSize = true;
            this.lblTRBeisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRBeisch.Location = new System.Drawing.Point(584, 210);
            this.lblTRBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTRBeisch.Name = "lblTRBeisch";
            this.lblTRBeisch.Size = new System.Drawing.Size(49, 21);
            this.lblTRBeisch.TabIndex = 27;
            this.lblTRBeisch.Text = "LISCH";
            // 
            // lblTMBeisch
            // 
            this.lblTMBeisch.AutoSize = true;
            this.lblTMBeisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMBeisch.Location = new System.Drawing.Point(584, 175);
            this.lblTMBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMBeisch.Name = "lblTMBeisch";
            this.lblTMBeisch.Size = new System.Drawing.Size(49, 21);
            this.lblTMBeisch.TabIndex = 26;
            this.lblTMBeisch.Text = "LISCH";
            // 
            // lblTREich
            // 
            this.lblTREich.AutoSize = true;
            this.lblTREich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTREich.Location = new System.Drawing.Point(469, 210);
            this.lblTREich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTREich.Name = "lblTREich";
            this.lblTREich.Size = new System.Drawing.Size(49, 21);
            this.lblTREich.TabIndex = 25;
            this.lblTREich.Text = "LISCH";
            // 
            // lblTMEich
            // 
            this.lblTMEich.AutoSize = true;
            this.lblTMEich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMEich.Location = new System.Drawing.Point(469, 175);
            this.lblTMEich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMEich.Name = "lblTMEich";
            this.lblTMEich.Size = new System.Drawing.Size(49, 21);
            this.lblTMEich.TabIndex = 24;
            this.lblTMEich.Text = "LISCH";
            // 
            // lblTRLich
            // 
            this.lblTRLich.AutoSize = true;
            this.lblTRLich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRLich.Location = new System.Drawing.Point(355, 210);
            this.lblTRLich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTRLich.Name = "lblTRLich";
            this.lblTRLich.Size = new System.Drawing.Size(49, 21);
            this.lblTRLich.TabIndex = 23;
            this.lblTRLich.Text = "LISCH";
            // 
            // lblTMLich
            // 
            this.lblTMLich.AutoSize = true;
            this.lblTMLich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMLich.Location = new System.Drawing.Point(355, 175);
            this.lblTMLich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMLich.Name = "lblTMLich";
            this.lblTMLich.Size = new System.Drawing.Size(49, 21);
            this.lblTMLich.TabIndex = 22;
            this.lblTMLich.Text = "LISCH";
            // 
            // lblTREisch
            // 
            this.lblTREisch.AutoSize = true;
            this.lblTREisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTREisch.Location = new System.Drawing.Point(240, 213);
            this.lblTREisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTREisch.Name = "lblTREisch";
            this.lblTREisch.Size = new System.Drawing.Size(49, 21);
            this.lblTREisch.TabIndex = 21;
            this.lblTREisch.Text = "LISCH";
            // 
            // lblTMEisch
            // 
            this.lblTMEisch.AutoSize = true;
            this.lblTMEisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMEisch.Location = new System.Drawing.Point(240, 176);
            this.lblTMEisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMEisch.Name = "lblTMEisch";
            this.lblTMEisch.Size = new System.Drawing.Size(49, 21);
            this.lblTMEisch.TabIndex = 20;
            this.lblTMEisch.Text = "LISCH";
            // 
            // lblTRLisch
            // 
            this.lblTRLisch.AutoSize = true;
            this.lblTRLisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRLisch.Location = new System.Drawing.Point(125, 210);
            this.lblTRLisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTRLisch.Name = "lblTRLisch";
            this.lblTRLisch.Size = new System.Drawing.Size(49, 21);
            this.lblTRLisch.TabIndex = 19;
            this.lblTRLisch.Text = "LISCH";
            // 
            // lblTMLisch
            // 
            this.lblTMLisch.AutoSize = true;
            this.lblTMLisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTMLisch.Location = new System.Drawing.Point(125, 175);
            this.lblTMLisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTMLisch.Name = "lblTMLisch";
            this.lblTMLisch.Size = new System.Drawing.Size(49, 21);
            this.lblTMLisch.TabIndex = 18;
            this.lblTMLisch.Text = "LISCH";
            // 
            // lblPFRlisch
            // 
            this.lblPFRlisch.AutoSize = true;
            this.lblPFRlisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPFRlisch.Location = new System.Drawing.Point(699, 139);
            this.lblPFRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFRlisch.Name = "lblPFRlisch";
            this.lblPFRlisch.Size = new System.Drawing.Size(49, 21);
            this.lblPFRlisch.TabIndex = 17;
            this.lblPFRlisch.Text = "LISCH";
            // 
            // lblSIRlisch
            // 
            this.lblSIRlisch.AutoSize = true;
            this.lblSIRlisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSIRlisch.Location = new System.Drawing.Point(701, 107);
            this.lblSIRlisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSIRlisch.Name = "lblSIRlisch";
            this.lblSIRlisch.Size = new System.Drawing.Size(49, 21);
            this.lblSIRlisch.TabIndex = 42;
            this.lblSIRlisch.Text = "LISCH";
            // 
            // lblSIBeisch
            // 
            this.lblSIBeisch.AutoSize = true;
            this.lblSIBeisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSIBeisch.Location = new System.Drawing.Point(586, 107);
            this.lblSIBeisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSIBeisch.Name = "lblSIBeisch";
            this.lblSIBeisch.Size = new System.Drawing.Size(49, 21);
            this.lblSIBeisch.TabIndex = 41;
            this.lblSIBeisch.Text = "LISCH";
            // 
            // lblSIEich
            // 
            this.lblSIEich.AutoSize = true;
            this.lblSIEich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSIEich.Location = new System.Drawing.Point(471, 107);
            this.lblSIEich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSIEich.Name = "lblSIEich";
            this.lblSIEich.Size = new System.Drawing.Size(49, 21);
            this.lblSIEich.TabIndex = 40;
            this.lblSIEich.Text = "LISCH";
            // 
            // lblSILich
            // 
            this.lblSILich.AutoSize = true;
            this.lblSILich.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSILich.Location = new System.Drawing.Point(357, 107);
            this.lblSILich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSILich.Name = "lblSILich";
            this.lblSILich.Size = new System.Drawing.Size(49, 21);
            this.lblSILich.TabIndex = 39;
            this.lblSILich.Text = "LISCH";
            // 
            // lblSIEisch
            // 
            this.lblSIEisch.AutoSize = true;
            this.lblSIEisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSIEisch.Location = new System.Drawing.Point(242, 107);
            this.lblSIEisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSIEisch.Name = "lblSIEisch";
            this.lblSIEisch.Size = new System.Drawing.Size(49, 21);
            this.lblSIEisch.TabIndex = 38;
            this.lblSIEisch.Text = "LISCH";
            // 
            // lblSILisch
            // 
            this.lblSILisch.AutoSize = true;
            this.lblSILisch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSILisch.Location = new System.Drawing.Point(127, 107);
            this.lblSILisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSILisch.Name = "lblSILisch";
            this.lblSILisch.Size = new System.Drawing.Size(49, 21);
            this.lblSILisch.TabIndex = 37;
            this.lblSILisch.Text = "LISCH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(-5, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 24);
            this.label16.TabIndex = 43;
            this.label16.Text = "Searching Info";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(347, 24);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(49, 21);
            this.lblInfo.TabIndex = 44;
            this.lblInfo.Text = "LISCH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 673);
            this.Controls.Add(this.lblRlisch);
            this.Controls.Add(this.lblBeisch);
            this.Controls.Add(this.lblEıch);
            this.Controls.Add(this.lblLıch);
            this.Controls.Add(this.lblEısch);
            this.Controls.Add(this.lblLısch);
            this.Controls.Add(this.lstbRlisch);
            this.Controls.Add(this.lstbBeisch);
            this.Controls.Add(this.lstbEich);
            this.Controls.Add(this.lstbLich);
            this.Controls.Add(this.lstbEisch);
            this.Controls.Add(this.lstbLisch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRandomNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRandomNumber.ResumeLayout(false);
            this.gbRandomNumber.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbRandomNumber;
        private System.Windows.Forms.GroupBox gbRandomNumber;
        private System.Windows.Forms.Button btnCreateRandom;
        private System.Windows.Forms.TextBox txtbCreateRandom;
        private System.Windows.Forms.ListBox lstbLisch;
        private System.Windows.Forms.ListBox lstbEisch;
        private System.Windows.Forms.ListBox lstbEich;
        private System.Windows.Forms.ListBox lstbBeisch;
        private System.Windows.Forms.ListBox lstbRlisch;
        private System.Windows.Forms.Label lblLısch;
        private System.Windows.Forms.Label lblEısch;
        private System.Windows.Forms.Label lblLıch;
        private System.Windows.Forms.Label lblEıch;
        private System.Windows.Forms.Label lblBeisch;
        private System.Windows.Forms.Label lblRlisch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPercentage;
        private System.Windows.Forms.Button bynSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPackingFactor;
        private System.Windows.Forms.Label lblTotalMemory;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblPFLisch;
        private System.Windows.Forms.Label lblPFEisch;
        private System.Windows.Forms.Label lblPFLich;
        private System.Windows.Forms.Label lblPFEich;
        private System.Windows.Forms.Label lblPFBeisch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTRRlisch;
        private System.Windows.Forms.Label lblTMRlisch;
        private System.Windows.Forms.Label lblTRBeisch;
        private System.Windows.Forms.Label lblTMBeisch;
        private System.Windows.Forms.Label lblTREich;
        private System.Windows.Forms.Label lblTMEich;
        private System.Windows.Forms.Label lblTRLich;
        private System.Windows.Forms.Label lblTMLich;
        private System.Windows.Forms.Label lblTREisch;
        private System.Windows.Forms.Label lblTMEisch;
        private System.Windows.Forms.Label lblTRLisch;
        private System.Windows.Forms.Label lblTMLisch;
        private System.Windows.Forms.Label lblPFRlisch;
        private System.Windows.Forms.Label lblAPRlisch;
        private System.Windows.Forms.Label lblAPBeisch;
        private System.Windows.Forms.Label lblAPEich;
        private System.Windows.Forms.Label lblAPLich;
        private System.Windows.Forms.Label lblAPEisch;
        private System.Windows.Forms.Label lblAPLisch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstbLich;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSIRlisch;
        private System.Windows.Forms.Label lblSIBeisch;
        private System.Windows.Forms.Label lblSIEich;
        private System.Windows.Forms.Label lblSILich;
        private System.Windows.Forms.Label lblSIEisch;
        private System.Windows.Forms.Label lblSILisch;
        private System.Windows.Forms.Label lblInfo;
    }
}

