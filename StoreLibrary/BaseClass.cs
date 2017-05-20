using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class BaseClass<T> where T : class
    {
        static internal TableManager tm;

        static BaseClass() { tm = TableManager.GetTableManager(typeof(T).Name); }

        //Отримати всі об’єкти
        static public T[] AllItems
        { get
            { return GetByQuery(""); }
        }

        //Отримати об’єкт по id
        static public T GetByID(Guid id)
        {
            while (true)
            {
                try
                {
                    return (T)Activator.CreateInstance(typeof(T), new object[] { tm.Table.Select("ID = '" + id.ToString() + "'")[0] });
                }
                catch { }
                if (tm.Recharge("Id = '" + id.ToString() + "'") == 0)
                    return null;
            }
        }

        //Отримати об’єкти по запиту
        static public T[] GetByQuery(string query) { return GetByQuery(query, true); }
        static public T[] GetByQuery(string query, bool seekInDB)
        {
            List<T> res = new List<T>();
            List<DataRow> ldrs = new List<DataRow>();
            ldrs.AddRange(tm.Table.Select(query));
            if (seekInDB)
            {
                string strSel = "";
                if (ldrs.Count < 200)
                {
                    foreach (DataRow dr in ldrs)
                        strSel += "'" + dr["ID"].ToString() + "',";
                    if (strSel.Length > 0)
                        strSel = strSel.Remove(strSel.Length - 1);
                    if (tm.Recharge(query + ((strSel == "") ? "" : ((query == "") ? "" : " and") + " ID not in (" + strSel + ")")) > 0)
                    {
                        ldrs.Clear();
                        ldrs.AddRange(tm.Table.Select(query));
                    }
                }
                else
                {
                    int count = 0;
                    foreach (DataRow dr in tm.GetIds(query))
                    {
                        if (tm.Table.Select("ID = '" + dr["ID"].ToString() + "'").Length == 0)
                        {
                            strSel += "'" + dr["ID"].ToString() + "',";
                            count++;
                        }
                        if (count == 200)
                        {
                            tm.Recharge(" ID in (" + strSel.Remove(strSel.Length - 1) + ")");
                            strSel = "";
                            count = 0;
                        }
                    }
                    if (strSel.Length > 0)
                        tm.Recharge(" ID in (" + strSel.Remove(strSel.Length - 1) + ")");
                    ldrs.Clear();
                    ldrs.AddRange(tm.Table.Select(query));
                }
            }
            foreach (DataRow dr in ldrs)
                res.Add((T)Activator.CreateInstance(typeof(T), new object[] { dr }));
            return res.ToArray();
        }

        /***********************************************/

        protected DataRow _row;
        private bool _isNew;

        public bool IsNew { get { return _isNew; } }

        public Guid Id
        {
            get
            {
                return new Guid(_row["Id"].ToString());
            }
        }

        public BaseClass()
        {
            _row = tm.Table.NewRow();
            _row["Id"] = Guid.NewGuid();
            _isNew = true;
        }

        public BaseClass(DataRow dr)
        {
            _row = dr;
            _isNew = false;
        }

        public void Save()
        {
            if (IsNew)
            {
                _isNew = false;
                tm.Table.Rows.Add(_row);
            }
            tm.Update(_row);
        }

        public void Delete()
        {
            _row.Delete();
            tm.Update(_row);
        }

        
    }
}
