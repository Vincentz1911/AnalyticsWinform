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
            this.button2 = new System.Windows.Forms.Button();
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
            this.ViewIDLabel = new System.Windows.Forms.Label();
            this.PropertyIDLabel = new System.Windows.Forms.Label();
            this.AccountIDLabel = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PropNameTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PropURLTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RefreshAccounts_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.CalFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.button1.Location = new System.Drawing.Point(299, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Day";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Week";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Month";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Quarter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Year";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 593);
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
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Goals";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(849, 614);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(496, 614);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Sessions";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(634, 614);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Last Sessions";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(967, 614);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Last Goal";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(135, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 26;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(261, 61);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 27;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ViewID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "PropertyID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "AccountID";
            // 
            // ViewIDLabel
            // 
            this.ViewIDLabel.AutoSize = true;
            this.ViewIDLabel.Location = new System.Drawing.Point(261, 159);
            this.ViewIDLabel.Name = "ViewIDLabel";
            this.ViewIDLabel.Size = new System.Drawing.Size(41, 13);
            this.ViewIDLabel.TabIndex = 33;
            this.ViewIDLabel.Text = "ViewID";
            this.ViewIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PropertyIDLabel
            // 
            this.PropertyIDLabel.AutoSize = true;
            this.PropertyIDLabel.Location = new System.Drawing.Point(132, 159);
            this.PropertyIDLabel.Name = "PropertyIDLabel";
            this.PropertyIDLabel.Size = new System.Drawing.Size(57, 13);
            this.PropertyIDLabel.TabIndex = 32;
            this.PropertyIDLabel.Text = "PropertyID";
            this.PropertyIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AccountIDLabel
            // 
            this.AccountIDLabel.AutoSize = true;
            this.AccountIDLabel.Location = new System.Drawing.Point(6, 159);
            this.AccountIDLabel.Name = "AccountIDLabel";
            this.AccountIDLabel.Size = new System.Drawing.Size(58, 13);
            this.AccountIDLabel.TabIndex = 31;
            this.AccountIDLabel.Text = "AccountID";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(305, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "Analytics";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PropNameTxt
            // 
            this.PropNameTxt.Location = new System.Drawing.Point(46, 40);
            this.PropNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PropNameTxt.Name = "PropNameTxt";
            this.PropNameTxt.Size = new System.Drawing.Size(335, 20);
            this.PropNameTxt.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "URL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PropURLTxt
            // 
            this.PropURLTxt.Location = new System.Drawing.Point(46, 71);
            this.PropURLTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PropURLTxt.Name = "PropURLTxt";
            this.PropURLTxt.Size = new System.Drawing.Size(335, 20);
            this.PropURLTxt.TabIndex = 44;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 251);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Property";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "UA-Key";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(62, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 20);
            this.textBox6.TabIndex = 50;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(305, 128);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 49;
            this.button11.Text = "Webmaster";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalFrom);
            this.groupBox2.Controls.Add(this.CalTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
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
            this.groupBox2.Text = "Date Range";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.RefreshAccounts_btn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.ViewIDLabel);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.PropertyIDLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.AccountIDLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 182);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(305, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 36;
            this.button10.Text = "OAuth2.0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SelectJSON_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 20);
            this.textBox5.TabIndex = 35;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // RefreshAccounts_btn
            // 
            this.RefreshAccounts_btn.Location = new System.Drawing.Point(6, 19);
            this.RefreshAccounts_btn.Name = "RefreshAccounts_btn";
            this.RefreshAccounts_btn.Size = new System.Drawing.Size(75, 23);
            this.RefreshAccounts_btn.TabIndex = 34;
            this.RefreshAccounts_btn.Text = "Refresh";
            this.RefreshAccounts_btn.UseVisualStyleBackColor = true;
            this.RefreshAccounts_btn.Click += new System.EventHandler(this.RefreshAccounts_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View";
            this.Text = "Google Analytics Testing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalFrom;
        private System.Windows.Forms.MonthCalendar CalTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label ViewIDLabel;
        private System.Windows.Forms.Label PropertyIDLabel;
        private System.Windows.Forms.Label AccountIDLabel;
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button11;
    }
}