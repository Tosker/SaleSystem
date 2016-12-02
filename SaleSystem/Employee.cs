using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleSystem
{
    class Employee
    {
        DataManager EmployeeData;
        ConnectionManager Database;
        public List<Employee> StaffList = new List<Employee>();

        private int _EmployeeID;
        private string _Firstname;
        private string _Lastname;
        private string _Title;
        private double _Wage;
        private int _EmployeeIndex;

        public int EmployeeID { get { return _EmployeeID; } set { _EmployeeID = value; } }
        public string Firstname { get { return _Firstname; } set { _Firstname = value; } }
        public string Lastname { get { return _Lastname; } set { _Lastname = value; } }
        public string Title { get { return _Title; } set { _Title = value; } }
        public double Wage { get { return _Wage; } set { _Wage = value; } }

        public Employee()
        {
            Database = new ConnectionManager();
        }

        public void Create(int employeeid)
        {
            _EmployeeID = employeeid;

            if (_Firstname == "" || _Lastname == "" || _Title == "" || _Wage == 0)
            {
                MessageBox.Show("Missing information! Operation was aborted.");
                return;
            }

            Database.AddEmployee(this);
        }

        public void Remove(Employee employee)
        {
            Database.RemoveEmployee(employee);
        }

        public void Update(Employee employee)
        {
            Database.UpdateEmployee(employee);
        }

        public void LoadAll()
        {
            EmployeeData = new DataManager();
            EmployeeData.RetrieveAll("Employees");

            for(int i = 0; i < EmployeeData.Items.Length; i++)
            {
                Employee tempEmployee = new Employee();
                tempEmployee.EmployeeID = Convert.ToInt32(EmployeeData.Items[i].ItemArray[0].ToString());
                tempEmployee.Firstname = EmployeeData.Items[i].ItemArray[1].ToString();
                tempEmployee.Lastname = EmployeeData.Items[i].ItemArray[2].ToString();
                tempEmployee.Wage = Convert.ToDouble(EmployeeData.Items[i].ItemArray[3].ToString());
                tempEmployee.Title = EmployeeData.Items[i].ItemArray[4].ToString();
                StaffList.Add(tempEmployee);
            }
        }

        public void Load(int employeeid)
        {
            EmployeeData = new DataManager();
            _EmployeeID = employeeid;
            EmployeeData.RetrieveAll("Employees");
            EmployeeData.PrimaryIndex = 0;

            _EmployeeIndex = EmployeeData.RowIndexOf(_EmployeeID);
            _Firstname = EmployeeData.ValueAsString(_EmployeeIndex, 1);
            _Lastname = EmployeeData.ValueAsString(_EmployeeIndex, 2);
            _Wage = Convert.ToDouble(EmployeeData.ValueAsString(_EmployeeIndex, 3));
            _Title = EmployeeData.ValueAsString(_EmployeeIndex, 4);
        }

    }
}
