using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SaleSystem
{
    public class Customer
    {
        public OrderHistory CustomerHistory;
        private ConnectionManager Database;
        private DataManager CustomerData;
        private string _CustomerID; //Email is ID
        private string _Firstname;
        private string _Lastname;
        private string _Address;
        private int _CustomerIndex;

        public string CustomerID { get { return _CustomerID; } }
        public string Firstname { get { return _Firstname; } set { _Firstname = value; } }
        public string Lastname { get { return _Lastname; } set { _Lastname = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }

        public Customer()
        {

        }

        public void Create(string customerid)
        {
            Database = new ConnectionManager();
            _CustomerID = customerid;

            if (Firstname == "" || Lastname == "" || Address == "")
            {
                MessageBox.Show("Missing information! Operation was aborted.");
                return;
            }

            Database.AddCustomer(this);
        }

        public void Load(string customerid)
        {
            _CustomerID = customerid;
            CustomerHistory = new OrderHistory(customerid);
            CustomerData = new DataManager();
            CustomerData.RetrieveAll("Customers");
            CustomerData.PrimaryIndex = 2;

            _CustomerIndex = CustomerData.RowIndexOf(_CustomerID);
            _Firstname = CustomerData.ValueAsString(_CustomerIndex, 0);
            _Lastname = CustomerData.ValueAsString(_CustomerIndex, 1);
            _Address = CustomerData.ValueAsString(_CustomerIndex, 3);
        }

    }
}
