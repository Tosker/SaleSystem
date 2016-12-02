using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SaleSystem
{
    class ConnectionManager
    {
        private string _ConnectionString;
        private string _TableName;
        private SqlDataAdapter Adapter;
        private SqlConnection Connection;

        public ConnectionManager()
        {
            _ConnectionString = Properties.Settings.Default.EmployeesConnectionString;
            Connection = new SqlConnection();
            Connection.ConnectionString = _ConnectionString;
        }

        public string ConnectionString
        {
            set { _ConnectionString = value; }
        }

        public string TableName
        {
            //Must be called before GrabSet() | Sets up string for table we want to grab from
            set { _TableName = String.Format("SELECT * FROM {0}", value); }
        }

        public DataSet GrabSet()
        {
            Connection.ConnectionString = _ConnectionString;
            Adapter = new System.Data.SqlClient.SqlDataAdapter(_TableName, Connection);
            System.Data.DataSet dat_set = new System.Data.DataSet();

            Connection.Open();
            Adapter.Fill(dat_set);
            Connection.Close();

            return dat_set;
        }

        public void AddEmployee(Employee employee)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "INSERT INTO Employees(Employee_ID, Employee_Firstname, Employee_Lastname,"
                                                + "Employee_Wage, Employee_Title) VALUES (@id, @firstname, @lastname,@wage,@title)";

            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@wage", System.Data.SqlDbType.Decimal));
            tCommand.Parameters.Add(new SqlParameter("@title", System.Data.SqlDbType.NVarChar));

            tCommand.Parameters["@id"].Value = employee.EmployeeID;
            tCommand.Parameters["@firstname"].Value = employee.Firstname;
            tCommand.Parameters["@lastname"].Value = employee.Lastname;
            tCommand.Parameters["@wage"].Value = employee.Wage;
            tCommand.Parameters["@title"].Value = employee.Title;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateEmployee(Employee employee)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "UPDATE Employees SET Employee_Firstname=@firstname, Employee_Lastname=@lastname, Employee_Wage=@wage,"
                                                                + "Employee_Title=@title WHERE Employee_ID=@id";

            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@wage", System.Data.SqlDbType.Decimal));
            tCommand.Parameters.Add(new SqlParameter("@title", System.Data.SqlDbType.NVarChar));

            tCommand.Parameters["@id"].Value = employee.EmployeeID;
            tCommand.Parameters["@firstname"].Value = employee.Firstname;
            tCommand.Parameters["@lastname"].Value = employee.Lastname;
            tCommand.Parameters["@wage"].Value = employee.Wage;
            tCommand.Parameters["@title"].Value = employee.Title;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void RemoveEmployee(Employee employee)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "DELETE FROM Employees WHERE Employee_ID =@id ";
            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters["@id"].Value = employee.EmployeeID;
            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void CheckEmployee(Employee employee)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "SELECT * FROM Employees WHERE Employee_ID=@id";
            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters["@id"].Value = employee.EmployeeID;
            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void AddCustomer(Customer customer)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "INSERT INTO Customers (email, firstname, lastname, address) VALUES (@email,@firstname,@lastname,@address)";

            tCommand.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@address", System.Data.SqlDbType.NVarChar));

            tCommand.Parameters["@email"].Value = customer.CustomerID;
            tCommand.Parameters["@firstname"].Value = customer.Firstname;
            tCommand.Parameters["@lastname"].Value = customer.Lastname;
            tCommand.Parameters["@address"].Value = customer.Address;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void AddToPricebook(Product product)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "INSERT INTO Products(ID, Name, Price, Category) VALUES (@id,@name,@price,@category)";

            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Decimal));
            tCommand.Parameters.Add(new SqlParameter("@category", System.Data.SqlDbType.NVarChar));

            tCommand.Parameters["@id"].Value = product.Id;
            tCommand.Parameters["@name"].Value = product.Name;
            tCommand.Parameters["@price"].Value = product.Price;
            tCommand.Parameters["@category"].Value = product.Category;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void RemoveFromPricebook(int id)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "DELETE FROM Products WHERE Id=@id";
            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
            tCommand.Parameters["@id"].Value = id;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void EditToPricebook(int id, string name, double price, string category)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "UPDATE Products SET Name=@name, Price=@price, Category=@category WHERE Id=@id";

            tCommand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Decimal));
            tCommand.Parameters.Add(new SqlParameter("@category", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));

            tCommand.Parameters["@name"].Value = name;
            tCommand.Parameters["@price"].Value = price;
            tCommand.Parameters["@category"].Value = category;
            tCommand.Parameters["@id"].Value = id;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public int InitializeOrder(string customerId, string date)
        {
            SqlCommand tCommand = new SqlCommand();
            tCommand.Connection = Connection;
            tCommand.CommandText = "INSERT INTO Orders (Customer_ID, Purchased_Date) VALUES(@id, @date)";

            tCommand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.NText));
            tCommand.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.NVarChar));
            tCommand.Parameters["@id"].Value = customerId;
            tCommand.Parameters["@date"].Value = date;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();

            DataSet ds = _GrabSet("SELECT TOP 1 Order_ID FROM Orders ORDER BY Order_ID DESC ");

            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
        }

        public void FinalizeOrder(int orderid, Item _purchased)
        {
            SqlCommand tCommand = new SqlCommand();
            Item purchased = _purchased;
            tCommand.Connection = Connection;
            tCommand.CommandText = "INSERT INTO Purchases (Order_ID, Product_Name, Product_Price, Product_ID) VALUES(@orderid, @name , @price, @itemid)";

            tCommand.Parameters.Add(new SqlParameter("@orderid", System.Data.SqlDbType.Int));
            tCommand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NText));
            tCommand.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Decimal));
            tCommand.Parameters.Add(new SqlParameter("@itemid", System.Data.SqlDbType.Int));
            tCommand.Parameters["@orderid"].Value = orderid;
            tCommand.Parameters["@name"].Value = purchased.ItemName;
            tCommand.Parameters["@price"].Value = purchased.ItemPrice;
            tCommand.Parameters["@itemid"].Value = purchased.ItemID;

            Connection.Open();
            tCommand.ExecuteNonQuery();
            Connection.Close();
        }

        private DataSet _GrabSet(string Query)
        {
            Connection.ConnectionString = _ConnectionString;
            Adapter = new System.Data.SqlClient.SqlDataAdapter(Query, Connection);
            System.Data.DataSet dat_set = new System.Data.DataSet();

            Connection.Open();
            Adapter.Fill(dat_set);
            Connection.Close();

            return dat_set;
        }
    }
}
