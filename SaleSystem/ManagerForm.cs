using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleSystem
{
    public partial class ManagerForm : Form
    {
        Pricebook _Pricebook;

        public ManagerForm()
        {
            InitializeComponent();
            _Pricebook = new Pricebook();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LoadItemView();
            LoadEmployeeView();
        }

        //Add item button for merchandise tab
        private void AddButton_Click(object sender, EventArgs e)
        {
            _Pricebook.CreateProduct(CurrentProductValues());
            _Pricebook.Refresh();
            inventoryView.Items.Clear();
            LoadItemView();
        }

        
        private void LoadItemView()
        {
            foreach(Product p in _Pricebook.Merchandise)
            {
                ListViewItem tempItem = new ListViewItem();
                tempItem.Text = p.Id.ToString();
                tempItem.SubItems.Add(p.Name);
                tempItem.SubItems.Add(p.Price.ToString());
                tempItem.SubItems.Add(p.Category);

                inventoryView.Items.Add(tempItem);
            }
        }

        //...This one
        private void LoadEmployeeView()
        {
            Employee AllEmployees = new Employee();
            AllEmployees.LoadAll();

            foreach(Employee e in AllEmployees.StaffList)
            {
                ListViewItem tempItem = new ListViewItem();
                tempItem.Text = e.EmployeeID.ToString();
                tempItem.SubItems.Add(e.Firstname + " " + e.Lastname);
                tempItem.SubItems.Add(e.Wage.ToString());
                tempItem.SubItems.Add(e.Title);

                employeeView.Items.Add(tempItem);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _Pricebook.RemoveProduct(CurrentProductValues());
            _Pricebook.Refresh();
            inventoryView.Items.Clear();
            LoadItemView();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _Pricebook.EditProduct(CurrentProductValues());
            _Pricebook.Refresh();
            inventoryView.Items.Clear();
            LoadItemView();
        }

        private Product CurrentProductValues()
        {
            Product tempProduct = new Product();
            tempProduct.Name = nameBox.Text;
            tempProduct.Category = descrBox.Text;
            tempProduct.Price = Convert.ToDouble(priceBox.Text);
            tempProduct.Id = Convert.ToInt32(idBox.Text);

            return tempProduct;
        }

        private void inventoryView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here I called a try-catch because it has minor errors grabbing
            //the selected index in the middle of this event being called.
            //This is just setting the text box's to the selected items text for easy editing
            try
            {
                int index = inventoryView.SelectedItems[0].Index;
                ListViewItem _temp = inventoryView.SelectedItems[0];
                idBox.Text    = _temp.Text;
                nameBox.Text  = _temp.SubItems[1].Text;
                priceBox.Text = _temp.SubItems[2].Text;
                descrBox.Text = _temp.SubItems[3].Text;
            }
            catch { }
        }

        //This point beyond 'e' means for the employee tab. EX: ecreateBtn == EmployeeCreateButton
        //Naming convention was sloppy due to change of plans
        private void ecreateBtn_Click(object sender, EventArgs e)
        {
            Employee newEmployee  = new Employee();
            newEmployee.Firstname = efirstBox.Text;
            newEmployee.Lastname  = elastBox.Text;
            newEmployee.Title     = etitleBox.Text;
            newEmployee.Wage      = Convert.ToDouble(ewageBox.Text);
            newEmployee.Create(Convert.ToInt32(eidBox.Text));
        }

        private void employeePage_Click(object sender, EventArgs e)
        {
            //Winform designer wants to be stupid and act upp when I remove this.
            //I am just keeping it for now.
        }

        private void eupdateBtn_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.Firstname = efirstBox.Text;
            tempEmployee.Lastname = elastBox.Text;
            tempEmployee.Title = etitleBox.Text;
            tempEmployee.Wage = Convert.ToDouble(ewageBox.Text);
            tempEmployee.EmployeeID = Convert.ToInt32(eidBox.Text);
            tempEmployee.Update(tempEmployee);
        }

        private void employeeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Try catch is used because SelectedIndexChanged is buggy when using .SelectedItems[0].Index
            try
            {
                ListViewItem SelectedItem = employeeView.SelectedItems[0];
                eidBox.Text = SelectedItem.Text;
                efirstBox.Text = SelectedItem.SubItems[1].Text.Split(' ')[0];
                elastBox.Text = SelectedItem.SubItems[1].Text.Split(' ')[1];
                ewageBox.Text = SelectedItem.SubItems[2].Text;
                etitleBox.Text = SelectedItem.SubItems[3].Text;
            }
                catch { }
        }

        private void eremoveBtn_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.Firstname = efirstBox.Text;
            tempEmployee.Lastname = elastBox.Text;
            tempEmployee.Title = etitleBox.Text;
            tempEmployee.Wage = Convert.ToDouble(ewageBox.Text);
            tempEmployee.EmployeeID = Convert.ToInt32(eidBox.Text);
            tempEmployee.Remove(tempEmployee);
        }
    }
}
