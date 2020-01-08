using Serilog;
using Serilog.Context;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database = FaceRecon;Trusted_Connection = True;MultipleActiveResultSets = true;";

            //ColumnOptions columnOptions = new ColumnOptions();
            //columnOptions.AdditionalColumns = new Collection<SqlColumn>();
            //columnOptions.AdditionalColumns.Add(new SqlColumn { ColumnName = "UserId", DataType = System.Data.SqlDbType.Int, AllowNull = false });
            //columnOptions.Store.Remove(StandardColumn.Exception);
            //columnOptions.Store.Remove(StandardColumn.Properties);

            ColumnOptions column = new ColumnOptions()
            {
                
                PrimaryKey = new SqlColumn {ColumnName = "Id",DataType = System.Data.SqlDbType.Int,AllowNull = false },
                Message = new ColumnOptions.MessageColumnOptions { ColumnName="Message",AllowNull = false,DataType = System.Data.SqlDbType.NVarChar}
            };
            

            //Log.Logger = new LoggerConfiguration().WriteTo.MSSqlServer(connectionString, "Logs", autoCreateSqlTable: true, columnOptions: columnOptions).CreateLogger();

            Log.Logger = new LoggerConfiguration().WriteTo.MSSqlServer(connectionString, "Visits",columnOptions:column,autoCreateSqlTable:true).CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDb());
        }
    }
}
