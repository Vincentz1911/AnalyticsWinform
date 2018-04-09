using System;
using System.Windows.Forms;

namespace AnalyticsWinform
{
    public partial class View : Form
    {
        Analytics ANA = new Analytics();
        Webmaster WEB = new Webmaster();
        Controller CTR = new Controller();
        System.Data.DataTable GDT = new System.Data.DataTable();

        public View()
        {
            InitializeComponent();

            WEB.Add2List();
            comboBox2.DataSource = WEB.OathFileList;
            comboBox2.DisplayMember = "Account";
            comboBox2.ValueMember = "File";

            ANA.Add2List();
            comboBox3.DataSource = ANA.OathFileList;
            comboBox3.DisplayMember = "Account";
            comboBox3.ValueMember = "File";

            CalFrom.MaxDate = DateTime.Now.AddDays(-2);
            CalFrom.MinDate = new DateTime(2005, 1, 1, 0, 0, 0);
            CalTo.MaxDate = DateTime.Now.AddDays(-1);
            CalTo.MinDate = new DateTime(2005, 1, 1, 0, 0, 0);
        }

        private void GetAnalyticsData_Click(object sender, EventArgs e)
        {
            if (CalFrom.SelectionRange.Start > CalTo.SelectionRange.Start)
            { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-1); }

            GDT = ANA.GetAnalyticsStream(listBox3.SelectedValue.ToString(), CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"), comboBox3.SelectedIndex);

            dataGridView1.DataSource = GDT;
            textBox1.Text = CTR.SumOfRows(GDT, 2).ToString();
            textBox2.Text = CTR.SumOfRows(GDT, 1).ToString();

            DateTime LastSession = DateTime.Parse(CTR.GetLast(GDT, "Sessions"));
            TimeSpan timeSpanSession = DateTime.Now - LastSession;
            textBox3.Text = LastSession.ToString("dd/MM/yyyy") + " - " + timeSpanSession.ToString("dd") + " days ago";

            DateTime LastGoal = DateTime.Parse(CTR.GetLast(GDT, "Goal Completions"));
            TimeSpan timeSpanGoal = DateTime.Now - LastGoal;
            textBox4.Text = LastGoal.ToString("dd/MM/yyyy") + " - " + timeSpanGoal.ToString("dd") + " days ago"; ;

            //DataRow lastRow = GDT.Rows[GDT.Rows.Count - 1];

        }
        private void RefreshAccounts_Click(object sender, EventArgs e)
        {
            ANA.GetAnalyticsAccounts(comboBox3.SelectedIndex);

            listBox1.DataSource = ANA.AccountsList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
            listBox2.DataSource = ANA.PropertyList;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "UA";
            listBox3.DataSource = ANA.ViewList;
            listBox3.DisplayMember = "Name";
            listBox3.ValueMember = "ID";

            if (listBox1.SelectedValue != null)
            {
                AccountIDLabel.Text = listBox1.SelectedValue.ToString();
                PropertyIDLabel.Text = listBox2.SelectedValue.ToString();
                ViewIDLabel.Text = listBox3.SelectedValue.ToString();

                comboBox1.DataSource = ANA.AccountsList;
                comboBox1.DisplayMember = "Name";
            }
        }
        private void SelectJSON_Click(object sender, EventArgs e) { CTR.GetOAuthFile(); }
        private void NewProperty_Click(object sender, EventArgs e) { textBox6.Text = ANA.CreateNewProperty(PropNameTxt.Text, PropURLTxt.Text, listBox1.SelectedValue.ToString(), comboBox3.SelectedIndex); }
        private void FixRegistryIE_Click(object sender, EventArgs e) { Controller.EnsureBrowserEmulationEnabled(); }
        private void LoadAnalyticsWeb_Click(object sender, EventArgs e) { webBrowser1.Navigate(ANA.GoToAnalyticsSite(listBox2.SelectedValue.ToString())); tabControl1.SelectedTab = tabPage2AWeb; }
        private void NewWebmasterSite_Click(object sender, EventArgs e) { WEB.AddWebmasterSite(PropURLTxt.Text, comboBox2.SelectedIndex); textBox5.Text = WEB.GetToken(PropURLTxt.Text, comboBox2.SelectedIndex); }
        private void VerifyWebMasterSite_Click(object sender, EventArgs e) { WEB.RunVerification(PropURLTxt.Text, comboBox2.SelectedIndex); WEB.SubmitSitemap(PropURLTxt.Text, comboBox2.SelectedIndex); }

        private void Day_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-1); }
        private void Week_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-7); }
        private void Month_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddMonths(-1); }
        private void Quarter_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddMonths(-3); }
        private void Year_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddYears(-1); }
        private void AllTime_button_Click(object sender, EventArgs e) { CalFrom.SelectionStart = new DateTime(2005, 1, 1, 0, 0, 0); CalTo.SelectionStart = CalTo.MaxDate; }
        private void FromDate_DateChanged(object sender, DateRangeEventArgs e) { label2.Text = CalFrom.SelectionStart.ToString("dd/MM/yyyy") + " - " + CalTo.SelectionStart.ToString("dd/MM/yyyy"); }
        private void ToDate_DateChanged(object sender, DateRangeEventArgs e) { label2.Text = CalFrom.SelectionStart.ToString("dd/MM/yyyy") + " - " + CalTo.SelectionStart.ToString("dd/MM/yyyy"); }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { if (listBox1.SelectedValue != null) AccountIDLabel.Text = listBox1.SelectedValue.ToString(); }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { if (listBox2.SelectedValue != null) PropertyIDLabel.Text = listBox2.SelectedValue.ToString(); }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) { if (listBox3.SelectedValue != null) ViewIDLabel.Text = listBox3.SelectedValue.ToString(); }

        private void webBrowser1_NewWindow(object sender, System.ComponentModel.CancelEventArgs e) {e.Cancel = true; webBrowser3.Navigate(webBrowser1.StatusText); }
        private void webBrowser2_NewWindow(object sender, System.ComponentModel.CancelEventArgs e) { e.Cancel = true; webBrowser3.Navigate(webBrowser2.StatusText); }

        private void button14_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(WEB.VisitSearchConsoleWeb(PropURLTxt.Text)); tabControl1.SelectedTab = tabPage4SCWeb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GDT = WEB.WebmasterQuery(PropURLTxt.Text, CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"), comboBox2.SelectedIndex, "query");
            dataGridView2.DataSource = GDT;

            GDT = WEB.WebmasterQuery(PropURLTxt.Text, CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"), comboBox2.SelectedIndex, "page");
            dataGridView3.DataSource = GDT;

            GDT = WEB.WebmasterQuery(PropURLTxt.Text, CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"), comboBox2.SelectedIndex, "device");
            dataGridView4.DataSource = GDT;

            GDT = WEB.WebmasterQuery(PropURLTxt.Text, CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"), comboBox2.SelectedIndex, "date");
            dataGridView5.DataSource = GDT;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

    }
}
