using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Sgra
{
   public class Db 
    {
       public static string DatabasePath =   System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath)) + @"\Sgra.accdb";
       public static string DatabaseConnection = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=True", DatabasePath);
       public static DataTable GetNewVehicles(string startDate=null,string endDate=null)
       {
           var sql = "Select * from vehicle where cdate([Invoice Date])>=? and cdate([Invoice Date])<=? and [Date Passing] is null";
           using(OleDbConnection cn=new OleDbConnection(DatabaseConnection))
           using(OleDbCommand cmd=new OleDbCommand(sql,cn))
           using (OleDbDataAdapter adp = new OleDbDataAdapter(cmd))
           {
               cmd.Parameters.AddWithValue("?", startDate);
               cmd.Parameters.AddWithValue("?", endDate);
               DataTable dt = new DataTable();
               dt.Columns.Add("Delete", typeof(bool));
               adp.Fill(dt);
               return dt;
           }
       }
       public static DataTable GetPassedVehicles(string startDate = null, string endDate = null)
       {
           var sql = "Select * from vehicle where cdate([Invoice Date])>=? and cdate([Invoice Date])<=? and [Date Passing] is not null";
           using (OleDbConnection cn = new OleDbConnection(DatabaseConnection))
           using (OleDbCommand cmd = new OleDbCommand(sql, cn))
           using (OleDbDataAdapter adp = new OleDbDataAdapter(cmd))
           {
               cmd.Parameters.AddWithValue("?", startDate);
               cmd.Parameters.AddWithValue("?", endDate);
               DataTable dt = new DataTable();
               dt.Columns.Add("Delete", typeof(bool));
               adp.Fill(dt);
               return dt;
           }
       }
       public static DataTable GetVehicles()
       {
           using (OleDbDataAdapter adp = new OleDbDataAdapter("select * from vehicle", DatabaseConnection))
           {
               DataTable dt = new DataTable();
               adp.Fill(dt);
               return dt;
           }
       }

       public static void DeleteVehicles(DataTable dt)
       {
          var sql = "delete from vehicle where [ID]=?";
           using(OleDbConnection cn=new OleDbConnection(DatabaseConnection))
           using(OleDbCommand cmd=new OleDbCommand(sql,cn))
           {
               cmd.Parameters.Add("?", OleDbType.Integer, 4);
               cn.Open();
               foreach (DataRow  row in dt.Rows)
               {
                  if(row.IsNull(0))
                      continue;
                  
                   if(bool.Parse(row[0].ToString()))
                   {
                       cmd.Parameters[0].Value = row[1];
                       cmd.ExecuteNonQuery();
                   }
               }
           }
       }
    }
}
