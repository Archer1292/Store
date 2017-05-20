using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    class TableManager
    {
        static private Dictionary<string, TableManager> _tableManagers = new Dictionary<string, TableManager>();
        static private DbProviderFactory _DbProviderFactory = DbProviderFactories.GetFactory("System.Data.OleDb");
        static private DbConnection _connection = _DbProviderFactory.CreateConnection();

        static private DbConnection Connection
        {
            get
            {
                while (true)
                {
                    try
                    {
                        if (_connection.State == ConnectionState.Broken) _connection.Close();
                        if (_connection.State == ConnectionState.Closed) _connection.Open();
                        return _connection;
                    }
                    catch
                    {
                    }
                }
            }
        }

        static TableManager() { _connection.ConnectionString = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString; ; }

        //Отримання менеджера потрібної таблиці
        static public TableManager GetTableManager(string tableName)
        {
            TableManager tm = null;
            try { tm = _tableManagers[tableName]; }
            catch
            {
                try
                {
                    tm = new TableManager(tableName);
                    _tableManagers.Add(tableName, tm);
                }
                catch { }
            }
            return tm;
        }

        //Знищення менеджера потрібної таблиці
        static public void RemoveTableManager(string tableName)
        { try { _tableManagers.Remove(tableName); } catch { } }



        private DbDataAdapter _da;
        private DataTable _dt;
        private DataTable _temp;
        private DbCommand _cmd;

        public DataTable Table { get { return _dt; } }

        internal TableManager(string tableName)
        {
            try
            {
                _da = TableManager._DbProviderFactory.CreateDataAdapter();
                _cmd = TableManager._DbProviderFactory.CreateCommand();
                DbCommandBuilder cb = TableManager._DbProviderFactory.CreateCommandBuilder();
                _cmd.Connection = TableManager.Connection;
                cb.ConflictOption = ConflictOption.OverwriteChanges;
                cb.DataAdapter = _da;
                _dt = new DataTable();
                _temp = new DataTable();
                _dt.TableName = _temp.TableName = tableName;
                _cmd.CommandText = "Select * from Voll_" + Table.TableName;
                _da.SelectCommand = _cmd;
                _da.InsertCommand = cb.GetInsertCommand();
                _da.DeleteCommand = cb.GetDeleteCommand();
                _da.UpdateCommand = cb.GetUpdateCommand();
                Recharge("1 = 2");
            }
            catch { }
        }

        //зачитати рядки об’єктів з БД в кеш
        internal int Recharge(string query)
        {
            _cmd.CommandText = "Select Voll_" + Table.TableName + ".* from Voll_"
               + Table.TableName + ((query == "") ? "" : " where " + query);
            try { return _da.Fill(_dt); }
            catch { }
            return 0;
        }

        //отримати ідентифікатори об’єктів з БД, що задовольняють запиту
        internal DataRowCollection GetIds(string query)
        {
            _cmd.CommandText = "Select ID from Voll_" + Table.TableName + ((query == null) ? "" : " where " + query);
            try
            {
                _da.Fill(_temp);
                return _temp.Rows;
            }
            catch { }
            return null;
        }

        //записати змінені рядки в БД
        internal int Update(DataRow dr) { return _da.Update(new DataRow[] { dr }); }
        internal int Update(DataRow[] drs) { return _da.Update(drs); }
    }
}
