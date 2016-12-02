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
    public partial class Form1 : Form
    {
        DataManager EmployeeData;

        private string   UserId = "NA"; //Global variable for what user within the system we are dealing with 'lookup' , 'cash out'
        private string   employeeName;
        private bool     isLoggedIn = false;
        private int      employeeID = 0;
        private TimeSpan StartTime;
        private TimeSpan EndTime;

        Customer CurrentCustomer;

        public Form1()
        {
            InitializeComponent();
            LoginDisplay(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemView.Columns[0].Width = 133;
            historyView.Columns[0].Width = 104;
            clockTimer.Start();
            dateLbl.Text = DateTime.Now.Month.ToString() + " / " + DateTime.Now.Day.ToString() + " / " + DateTime.Now.Year.ToString();
            AccessLevel(0);
            isLoggedIn = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            EmployeeData = new DataManager();
            EmployeeData.RetrieveAll("Employees");
            EmployeeData.PrimaryIndex = 0;
            int index = EmployeeData.RowIndexOf(Convert.ToInt32(loginBox.Text));
            employeeName = EmployeeData.ValueAsString(index, 1);
            employeeID = Convert.ToInt32(EmployeeData.ValueAsString(index, 0));
            string title = EmployeeData.ValueAsString(index, 4);

            //DataSet tempData = DataConnection.UserInfo(loginBox.Text);
            //employeeID   = Convert.ToInt32(tempData.Tables[0].Rows[0].ItemArray[0]);
            //employeeName = tempData.Tables[0].Rows[0].ItemArray[1].ToString();

            switch (title)
            {
                case "Manager":
                    AccessLevel(1);
                    break;
                case "Assistant Manager":
                    AccessLevel(2);
                    break;
                case "CSR":
                    AccessLevel(3);
                    break;
            }

        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            isLoggedIn = false; //Being detected in timer
        }

        private void lookupButton_Click(object sender, EventArgs e)
        {
            try {
                UserId = userBox.Text;
                itemView.Items.Clear();
                historyView.Items.Clear();

                CurrentCustomer = new Customer();
                CurrentCustomer.Load(UserId);

                nameBox.Text = CurrentCustomer.Firstname;
                lastBox.Text = CurrentCustomer.Lastname;
                addressBox.Text = CurrentCustomer.Address;
                emailBox.Text = UserId;

                foreach (Order o in CurrentCustomer.CustomerHistory.CustomerOrders)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = o.orderid.ToString();
                    item.SubItems.Add(o.purchasedate.ToString().Split('.')[0]);//Split is to take off miliseconds

                    historyView.Items.Add(item);
                }
            }
            catch(Exception ex) { MessageBox.Show("Inavlid email - Please check for errors and try again."); }
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            ManagerForm ManagerForm1 = new ManagerForm(); //Opens manager form and passes it the loaded pricebook XML
            ManagerForm1.ShowDialog();
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            if (UserId != "NA") //NA is default declaration unless changed. Meaning we cannot cash anyone out if a user has not been 'looked up'
            {
                PosForm PosForm1 = new PosForm(UserId);
                PosForm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must lookup a user first!");
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignupForm SignUp = new SignupForm();
            SignUp.ShowDialog();
        }

        private void historyView_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemView.Items.Clear();
            try
            {
                CurrentCustomer.CustomerHistory.LoadAllItems(Convert.ToInt32(historyView.SelectedItems[0].Text));

                foreach (Purchase p in CurrentCustomer.CustomerHistory.PurchasedItems)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.productname;
                    item.SubItems.Add(p.productprice.ToString());

                    itemView.Items.Add(item);
                }
            }
            catch { }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = "Time: " + DateTime.Now.TimeOfDay.ToString().Split('.')[0]; //Split is only being used to remove miliseconds

            if(!isLoggedIn && employeeID != 0)       //Picking up if no one is logged in and if so
            {                                       //have we began the process of breaking it all down?
                EndTime = DateTime.Now.TimeOfDay;
                TimeSpan total = EndTime - StartTime;

                employeeID   = 0;                   
                employeeName = "NA";                //Here we are breaking everything down
                isLoggedIn   = false;               //and setting it back to a default value so nothing
                AccessLevel(0);                                           //gets mingled when a new employee logs in
                EndTime   = new TimeSpan();         
                StartTime = new TimeSpan();         
                MessageBox.Show(total.ToString());
            }

        }

        private void AccessLevel(int level)
        {
            //Setting which buttons can and cannot be clicked based on authority of the user
            if(level == 1)
            {
                ManageButton.Enabled = true;
                SaleButton.Enabled   = true;
                SignupButton.Enabled = true;
                lookupButton.Enabled = true;
                updateBtn.Enabled    = true;
                LoginDisplay(true);
            }
            else if (level == 2)
            {
                ManageButton.Enabled = true;
                SaleButton.Enabled   = true;
                SignupButton.Enabled = true;
                lookupButton.Enabled = true;
                updateBtn.Enabled    = true;
                LoginDisplay(true);
            }
            else if (level == 3)
            {
                ManageButton.Enabled = false;
                SaleButton.Enabled   = true;
                SignupButton.Enabled = true;
                lookupButton.Enabled = true;
                updateBtn.Enabled    = true;
                LoginDisplay(true);
            }
            else if (level == 0)
            {
                ManageButton.Enabled = false;
                SaleButton.Enabled   = false;
                SignupButton.Enabled = false;
                lookupButton.Enabled = false;
                updateBtn.Enabled    = false;
                LoginDisplay(false);
            }
        }

        private void LoginDisplay(bool isIn)
        {
            if(isIn)
            {
                loginBtn.Visible    = false;
                loginBox.Visible    = false;
                employeeLbl.Visible = true;
                signoutBtn.Visible  = true;
                isLoggedIn          = true;

                employeeLbl.Text = "Logged On: " + employeeName;

                StartTime        = DateTime.Now.TimeOfDay;
            }
            else
            {
                loginBtn.Visible    = true;
                loginBox.Visible    = true;
                employeeLbl.Visible = false;
                signoutBtn.Visible  = false;
            }
        }

        //This is 'Looking Up' the user for customer information and history of purchases
        private void GrabInfo(string userId)
        {

            /*string[] tempInfo = DataConnection.GrabCustomer(userId);
            if (tempInfo[0] != null)
            {
                nameBox.Text    = tempInfo[0];
                lastBox.Text    = tempInfo[1];
                addressBox.Text = tempInfo[2];
                emailBox.Text   = userId;
            }
            else
            {
                nameBox.Text    = "N/A";
                lastBox.Text    = "N/A";
                addressBox.Text = "N/A";
                emailBox.Text   = "N/A";
                UserId          = "NA";
            }*/
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void Inventory_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }
    }
}
