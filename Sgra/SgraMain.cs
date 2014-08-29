using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Access;
using System.Runtime.InteropServices;

namespace Sgra
{
    public partial class SgraMain : System.Windows.Forms.Form
    {
        public SgraMain()
        {
            InitializeComponent();
        }

        private void SgraMain_Load(object sender, EventArgs e)
        {
            var databaseLocation = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath)) + @"\Sgra.accdb";
            var query = "vehicle";
            kvBtnImport.Click += (sa, ea) =>
                {
                    kvOpenFile.Filter = "Microsoft Excel (*.xlsx)|*.xlsx";

                   // kvOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                    if (kvOpenFile.ShowDialog() == DialogResult.OK)
                    {
                        var locationToExportTo = kvOpenFile.FileName;
                        try
                        {
                            ImportAccessToExcelQuery(databaseLocation, query, locationToExportTo);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Invalid format of data."); 
                        }
                    }
                };
        }

        private static void ExportAccessToExcelQuery(string databaseLocation, string queryNameToExport, string locationToExportTo)
        {
            var app = new Microsoft.Office.Interop.Access.Application();
         
            app.OpenCurrentDatabase(databaseLocation);
            app.DoCmd.TransferSpreadsheet(AcDataTransferType.acExport, AcSpreadSheetType.acSpreadsheetTypeExcel12,
                                                  queryNameToExport, locationToExportTo, true);
            app.CloseCurrentDatabase();
            app.Quit();
            Marshal.ReleaseComObject(app);
        }
        private static void ImportAccessToExcelQuery(string databaseLocation, string queryNameToExport, string locationToExportTo)
        {
            var app = new Microsoft.Office.Interop.Access.Application();

            app.OpenCurrentDatabase(databaseLocation);
            app.DoCmd.TransferSpreadsheet(AcDataTransferType.acImport, AcSpreadSheetType.acSpreadsheetTypeExcel12,
                                                  queryNameToExport, locationToExportTo, true);
            app.CloseCurrentDatabase();
            app.Quit();
            Marshal.ReleaseComObject(app);
        }
        private void ExportData(string fileName)
        {
            var connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", fileName);

            using (var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString))
            {
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
            }

        }
    }
}
