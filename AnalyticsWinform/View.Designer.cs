namespace AnalyticsWinform
{
    partial class View
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
            this.CalFrom = new System.Windows.Forms.MonthCalendar();
            this.CalTo = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.Day_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PropNameTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PropURLTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.ViewIDLabel = new System.Windows.Forms.TextBox();
            this.PropertyIDLabel = new System.Windows.Forms.TextBox();
            this.AccountIDLabel = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.RefreshAccounts_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Analytics = new System.Windows.Forms.TabPage();
            this.tabPage3SearchConsole = new System.Windows.Forms.TabPage();
            this.tabPage2AWeb = new System.Windows.Forms.TabPage();
            this.tabPage4SCWeb = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage5InfoWeb = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1Analytics.SuspendLayout();
            this.tabPage3SearchConsole.SuspendLayout();
            this.tabPage2AWeb.SuspendLayout();
            this.tabPage4SCWeb.SuspendLayout();
            this.tabPage5InfoWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // CalFrom
            // 
            this.CalFrom.Location = new System.Drawing.Point(12, 25);
            this.CalFrom.MaxSelectionCount = 1;
            this.CalFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CalFrom.Name = "CalFrom";
            this.CalFrom.ShowToday = false;
            this.CalFrom.TabIndex = 0;
            this.CalFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.FromDate_DateChanged);
            // 
            // CalTo
            // 
            this.CalTo.Location = new System.Drawing.Point(203, 25);
            this.CalTo.MaxSelectionCount = 1;
            this.CalTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CalTo.Name = "CalTo";
            this.CalTo.ShowToday = false;
            this.CalTo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Analytics Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetAnalyticsData_Click);
            // 
            // Day_button
            // 
            this.Day_button.Location = new System.Drawing.Point(12, 199);
            this.Day_button.Name = "Day_button";
            this.Day_button.Size = new System.Drawing.Size(75, 23);
            this.Day_button.TabIndex = 5;
            this.Day_button.Text = "Day";
            this.Day_button.UseVisualStyleBackColor = true;
            this.Day_button.Click += new System.EventHandler(this.Day_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Week";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Week_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Month";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Month_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Quarter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Quarter_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Year";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Year_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 674);
            this.dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(108, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "All Time";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AllTime_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Goals";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 22);
            this.textBox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Sessions";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 22);
            this.textBox3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Last Sessions";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(689, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 22);
            this.textBox4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Last Goal";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(135, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 26;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(261, 67);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 27;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ViewID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "PropertyID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "AccountID";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(305, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "Analytics";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NewProperty_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PropNameTxt
            // 
            this.PropNameTxt.Location = new System.Drawing.Point(46, 27);
            this.PropNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PropNameTxt.Name = "PropNameTxt";
            this.PropNameTxt.Size = new System.Drawing.Size(335, 20);
            this.PropNameTxt.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "URL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PropURLTxt
            // 
            this.PropURLTxt.Location = new System.Drawing.Point(46, 54);
            this.PropURLTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PropURLTxt.Name = "PropURLTxt";
            this.PropURLTxt.Size = new System.Drawing.Size(335, 20);
            this.PropURLTxt.TabIndex = 44;
            this.PropURLTxt.Text = "https://spacetravelersguild.yolasite.com/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.PropURLTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.PropNameTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 203);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Analytics and Search Console Property";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(305, 166);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 58;
            this.button14.Text = "Visit Web";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Meta Tag";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(62, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 20);
            this.textBox5.TabIndex = 56;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Gmail";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(305, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 52;
            this.button9.Text = "Webmaster";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NewWebmasterSite_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "UA Tag";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(62, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 20);
            this.textBox6.TabIndex = 50;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(305, 138);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 49;
            this.button11.Text = "Verify";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.VerifyWebMasterSite_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.CalFrom);
            this.groupBox2.Controls.Add(this.CalTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Day_button);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 293);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date Range and Collect Data from Analytics";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Get Webmaster Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.ViewIDLabel);
            this.groupBox3.Controls.Add(this.PropertyIDLabel);
            this.groupBox3.Controls.Add(this.AccountIDLabel);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.RefreshAccounts_btn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 230);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Analytics Accounts, Properties and Views";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(9, 191);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 23);
            this.button13.TabIndex = 61;
            this.button13.Text = "Reg Fix IE7->IE11";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.FixRegistryIE_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(135, 192);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 23);
            this.button12.TabIndex = 60;
            this.button12.Text = "Go To Analytics Page";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.LoadAnalyticsWeb_Click);
            // 
            // ViewIDLabel
            // 
            this.ViewIDLabel.Location = new System.Drawing.Point(261, 166);
            this.ViewIDLabel.Name = "ViewIDLabel";
            this.ViewIDLabel.Size = new System.Drawing.Size(119, 20);
            this.ViewIDLabel.TabIndex = 59;
            // 
            // PropertyIDLabel
            // 
            this.PropertyIDLabel.Location = new System.Drawing.Point(135, 166);
            this.PropertyIDLabel.Name = "PropertyIDLabel";
            this.PropertyIDLabel.Size = new System.Drawing.Size(120, 20);
            this.PropertyIDLabel.TabIndex = 58;
            // 
            // AccountIDLabel
            // 
            this.AccountIDLabel.Location = new System.Drawing.Point(9, 165);
            this.AccountIDLabel.Name = "AccountIDLabel";
            this.AccountIDLabel.Size = new System.Drawing.Size(120, 20);
            this.AccountIDLabel.TabIndex = 57;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(87, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 21);
            this.comboBox3.TabIndex = 56;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(305, 25);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 36;
            this.button10.Text = "OAuth2.0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SelectJSON_Click);
            // 
            // RefreshAccounts_btn
            // 
            this.RefreshAccounts_btn.Location = new System.Drawing.Point(6, 25);
            this.RefreshAccounts_btn.Name = "RefreshAccounts_btn";
            this.RefreshAccounts_btn.Size = new System.Drawing.Size(75, 23);
            this.RefreshAccounts_btn.TabIndex = 34;
            this.RefreshAccounts_btn.Text = "Refresh";
            this.RefreshAccounts_btn.UseVisualStyleBackColor = true;
            this.RefreshAccounts_btn.Click += new System.EventHandler(this.RefreshAccounts_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(833, 705);
            this.webBrowser1.TabIndex = 49;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1Analytics);
            this.tabControl1.Controls.Add(this.tabPage3SearchConsole);
            this.tabControl1.Controls.Add(this.tabPage2AWeb);
            this.tabControl1.Controls.Add(this.tabPage4SCWeb);
            this.tabControl1.Controls.Add(this.tabPage5InfoWeb);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(405, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 737);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1Analytics
            // 
            this.tabPage1Analytics.Controls.Add(this.dataGridView1);
            this.tabPage1Analytics.Controls.Add(this.label5);
            this.tabPage1Analytics.Controls.Add(this.label4);
            this.tabPage1Analytics.Controls.Add(this.textBox1);
            this.tabPage1Analytics.Controls.Add(this.textBox3);
            this.tabPage1Analytics.Controls.Add(this.textBox2);
            this.tabPage1Analytics.Controls.Add(this.label6);
            this.tabPage1Analytics.Controls.Add(this.label7);
            this.tabPage1Analytics.Controls.Add(this.textBox4);
            this.tabPage1Analytics.Location = new System.Drawing.Point(4, 25);
            this.tabPage1Analytics.Name = "tabPage1Analytics";
            this.tabPage1Analytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Analytics.Size = new System.Drawing.Size(839, 708);
            this.tabPage1Analytics.TabIndex = 0;
            this.tabPage1Analytics.Text = "Analytics Data";
            this.tabPage1Analytics.UseVisualStyleBackColor = true;
            // 
            // tabPage3SearchConsole
            // 
            this.tabPage3SearchConsole.Controls.Add(this.tabControl2);
            this.tabPage3SearchConsole.Location = new System.Drawing.Point(4, 25);
            this.tabPage3SearchConsole.Name = "tabPage3SearchConsole";
            this.tabPage3SearchConsole.Size = new System.Drawing.Size(839, 708);
            this.tabPage3SearchConsole.TabIndex = 2;
            this.tabPage3SearchConsole.Text = "Search Console Data";
            this.tabPage3SearchConsole.UseVisualStyleBackColor = true;
            // 
            // tabPage2AWeb
            // 
            this.tabPage2AWeb.Controls.Add(this.webBrowser1);
            this.tabPage2AWeb.Location = new System.Drawing.Point(4, 22);
            this.tabPage2AWeb.Name = "tabPage2AWeb";
            this.tabPage2AWeb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2AWeb.Size = new System.Drawing.Size(839, 711);
            this.tabPage2AWeb.TabIndex = 1;
            this.tabPage2AWeb.Text = "Analytics Web";
            this.tabPage2AWeb.UseVisualStyleBackColor = true;
            // 
            // tabPage4SCWeb
            // 
            this.tabPage4SCWeb.Controls.Add(this.webBrowser2);
            this.tabPage4SCWeb.Location = new System.Drawing.Point(4, 22);
            this.tabPage4SCWeb.Name = "tabPage4SCWeb";
            this.tabPage4SCWeb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4SCWeb.Size = new System.Drawing.Size(839, 711);
            this.tabPage4SCWeb.TabIndex = 3;
            this.tabPage4SCWeb.Text = "Search Console Web";
            this.tabPage4SCWeb.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(833, 705);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser2_NewWindow);
            // 
            // tabPage5InfoWeb
            // 
            this.tabPage5InfoWeb.Controls.Add(this.webBrowser3);
            this.tabPage5InfoWeb.Location = new System.Drawing.Point(4, 22);
            this.tabPage5InfoWeb.Name = "tabPage5InfoWeb";
            this.tabPage5InfoWeb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5InfoWeb.Size = new System.Drawing.Size(839, 711);
            this.tabPage5InfoWeb.TabIndex = 4;
            this.tabPage5InfoWeb.Text = "Info Web";
            this.tabPage5InfoWeb.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(3, 3);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(833, 705);
            this.webBrowser3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(825, 673);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(839, 708);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Queries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(825, 679);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Devices";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(825, 673);
            this.dataGridView4.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(831, 679);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dates";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(831, 679);
            this.dataGridView5.TabIndex = 2;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "View";
            this.Text = "Google Analytics Testing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1Analytics.ResumeLayout(false);
            this.tabPage1Analytics.PerformLayout();
            this.tabPage3SearchConsole.ResumeLayout(false);
            this.tabPage2AWeb.ResumeLayout(false);
            this.tabPage4SCWeb.ResumeLayout(false);
            this.tabPage5InfoWeb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalFrom;
        private System.Windows.Forms.MonthCalendar CalTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Day_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PropNameTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PropURLTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RefreshAccounts_btn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox ViewIDLabel;
        private System.Windows.Forms.TextBox PropertyIDLabel;
        private System.Windows.Forms.TextBox AccountIDLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Analytics;
        private System.Windows.Forms.TabPage tabPage2AWeb;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TabPage tabPage3SearchConsole;
        private System.Windows.Forms.TabPage tabPage4SCWeb;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TabPage tabPage5InfoWeb;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}