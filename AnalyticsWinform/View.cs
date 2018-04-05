using System;
using System.Data;
using System.Windows.Forms;

namespace AnalyticsWinform
{
    public partial class View : Form
    {
        Controller ctr = new Controller();
        DataTable GDT = new DataTable();

        public View()
        {
            InitializeComponent();
            textBox5.Text = Controller.email;

            CalFrom.MaxDate = DateTime.Now.AddDays(-2);
            CalFrom.MinDate = new DateTime(2005, 1, 1, 0, 0, 0);
            CalTo.MaxDate = DateTime.Now.AddDays(-1);
            CalTo.MinDate = new DateTime(2005, 1, 1, 0, 0, 0);
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            if (CalFrom.SelectionRange.Start > CalTo.SelectionRange.Start)
            { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-1); }

            GDT = ctr.GetAnalyticsStream(listBox3.SelectedValue.ToString(),
                CalFrom.SelectionStart.ToString("yyyy-MM-dd"), CalTo.SelectionStart.ToString("yyyy-MM-dd"));

            dataGridView1.DataSource = GDT;
            textBox1.Text = ctr.SumOfRows(GDT, 2).ToString();
            textBox2.Text = ctr.SumOfRows(GDT, 1).ToString();

            DateTime LastSession = DateTime.Parse(ctr.GetLast(GDT, "Sessions"));
            TimeSpan timeSpanSession = DateTime.Now - LastSession;
            textBox3.Text = LastSession.ToString("dd/MM/yyyy") + " - " + timeSpanSession.ToString("dd") + " days since";

            DateTime LastGoal = DateTime.Parse(ctr.GetLast(GDT, "Goal Completions"));
            TimeSpan timeSpanGoal = DateTime.Now - LastGoal;
            textBox4.Text = LastGoal.ToString("dd/MM/yyyy") + " - " + timeSpanGoal.ToString("dd") + " days since"; ;

            //DataRow lastRow = GDT.Rows[GDT.Rows.Count - 1];

        }
        private void RefreshAccounts_Click(object sender, EventArgs e)
        {
            ctr.GetAnalyticsAccounts();

            listBox1.DataSource = ctr.AccountsList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
            listBox2.DataSource = ctr.PropertyList;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
            listBox3.DataSource = ctr.ViewList;
            listBox3.DisplayMember = "Name";
            listBox3.ValueMember = "ID";

            AccountIDLabel.Text = listBox1.SelectedValue.ToString();
            PropertyIDLabel.Text = listBox2.SelectedValue.ToString();
            ViewIDLabel.Text = listBox3.SelectedValue.ToString();

            comboBox1.DataSource = ctr.AccountsList;
            comboBox1.DisplayMember = "Name";
        }
        private void SelectJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"~";
            openFileDialog1.Title = "Select OAuth 2.0 client ID";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Filter = "JSON (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.DefaultExt = ".json";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) { Controller.secret = openFileDialog1.FileName; }
        }
        private void NewProperty_Click(object sender, EventArgs e) { textBox6.Text = ctr.CreateNewProperty(PropNameTxt.Text, PropURLTxt.Text, listBox1.SelectedValue.ToString()); }
        private void textBox5_TextChanged(object sender, EventArgs e) { Controller.email = textBox5.Text; }

        private void button2_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-1); }
        private void button3_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddDays(-7); }
        private void button4_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddMonths(-1); }
        private void button5_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddMonths(-3); }
        private void button6_Click(object sender, EventArgs e) { CalFrom.SelectionStart = CalTo.SelectionStart.AddYears(-1); }
        private void button7_Click(object sender, EventArgs e) { CalFrom.SelectionStart = new DateTime(2005, 1, 1, 0, 0, 0); CalTo.SelectionStart = CalTo.MaxDate; }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { label2.Text = CalFrom.SelectionStart.ToString("dd/MM/yyyy") + " - " + CalTo.SelectionStart.ToString("dd/MM/yyyy"); }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e) { label2.Text = CalFrom.SelectionStart.ToString("dd/MM/yyyy") + " - " + CalTo.SelectionStart.ToString("dd/MM/yyyy"); }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { AccountIDLabel.Text = listBox1.SelectedValue.ToString(); }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { PropertyIDLabel.Text = listBox2.SelectedValue.ToString(); }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) { ViewIDLabel.Text = listBox3.SelectedValue.ToString(); }

        private void button11_Click(object sender, EventArgs e)
        {
            ctr.RunVerification(PropURLTxt.Text);
        }
    }
}
