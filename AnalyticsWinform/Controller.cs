using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Net.Http;
using Microsoft.Win32;

namespace AnalyticsWinform
{
    public class Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public static string[] OAuth2Files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "JSON", "*.json");
        public Oath2Files_cls Oath_cls { get; set; }

        public void GetOAuthFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Select OAuth 2.0 client ID",
                InitialDirectory = @"~",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Filter = "JSON (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                DefaultExt = ".json"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Analytics.OathFileList.Add(new Oath2Files_cls { File = openFileDialog1.FileName, Account = Path.GetFileName(openFileDialog1.FileName).Split('_')[0] + "@gmail.com" });
                //OathFileList.Add(new Oath2Files_cls { File = openFileDialog1.FileName, Account = Path.GetFileName(openFileDialog1.FileName).Split('_')[0] + "@gmail.com" });
            }
        }

        //Get sum of rows from Datatable
        public Decimal SumOfRows(DataTable DT, int collumn)
        {
            decimal o = 0;
            if (DT != null) { for (int i = 0; i < DT.Rows.Count; i++) { o += decimal.Parse(DT.Rows[i][collumn].ToString()); } }
            return o;
        }
        //Get last row with value from Datatable
        public string GetLast(DataTable DT, string collumn)
        {
            int value = 0;
            if (DT != null)
            {
                for (int i = 1; i < DT.Rows.Count; i++)
                {
                    value = int.Parse(DT.Rows[DT.Rows.Count - i][collumn].ToString());
                    if (value > 0) { return DT.Rows[DT.Rows.Count - i]["Date"].ToString(); }
                }
            }
            return null;
        }

        public static void EnsureBrowserEmulationEnabled(string exename = "AnalyticsWinform.exe", bool uninstall = false)
        {
            try
            {
                using (var rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                {
                    if (!uninstall) { dynamic value = rk.GetValue(exename); if (value == null) rk.SetValue(exename, (uint)11001, RegistryValueKind.DWord); } else rk.DeleteValue(exename);
                }
            }
            catch
            {
            }
        }

    }
}

