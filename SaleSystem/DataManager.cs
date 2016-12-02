using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleSystem
{
    class DataManager
    {
        private ConnectionManager Database;
        private DataSet NSA;
        public DataRow[] Items;
        private int RowCount;
        private int _PrimaryIndex;

        public DataManager()
        {
            Database = new ConnectionManager();
        }

        public int PrimaryIndex
        {
            set { _PrimaryIndex = value; } //Must be set before any GrabRow() | Sets which column primary key is in
        }

        public int Count
        {
            get { return RowCount; } //Must be set before any GrabRow() | Sets which column primary key is in
        }

        public void RetrieveAll(string TableName)
        {
            Database.TableName = TableName;
            NSA = Database.GrabSet();
            RowCount = NSA.Tables[0].Rows.Count;
            Items = new DataRow[RowCount];

            for(int i = 0; i < RowCount; i ++)
            {
                Items[i] = NSA.Tables[0].Rows[i];
            }
        }

        public string ValueAsString(int RowIndexOf, int ColumnIndex)
        {
            //RowIndexOf is the index of the row we want in Items[]. 
            //Column Index is for which column in that row we return the value of
            return Items[RowIndexOf].ItemArray[ColumnIndex].ToString();
        }

        //Below are methods to find the index of a row with the assigned porimary key. 
        //For now only ints, strings and doubles
        public int RowIndexOf(int primaryKey)
        {
            for (int r = 0; r < RowCount; r++)
            {
                if (Convert.ToInt32(Items[r].ItemArray[_PrimaryIndex].ToString()) == primaryKey)
                {
                    return r;
                }
            }
            return -1;
        }

        public int RowIndexOf(string primaryKey)
        {
            for (int r = 0; r < RowCount; r++)
            {
                if (Items[r].ItemArray[_PrimaryIndex].ToString().ToLower() == primaryKey.ToLower()) //ToLower so its not case sensitive
                {
                    return r;
                }
            }
            return -1;
        }

        public int RowIndexOf(double primaryKey)
        {
            for (int r = 0; r < RowCount; r++)
            {
                if (Convert.ToDouble(Items[r].ItemArray[_PrimaryIndex].ToString()) == primaryKey)
                {
                    return r;
                }
            }
            return -1;
        }

    }
}
