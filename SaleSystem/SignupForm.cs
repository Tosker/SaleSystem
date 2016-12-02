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
    public partial class SignupForm : Form
    {
        Customer newMember;

        public SignupForm()
        {
            InitializeComponent();
            newMember = new Customer();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            newMember.Firstname = firstBox.Text;
            newMember.Lastname = lastBox.Text;
            newMember.Address = addressBox.Text;

            newMember.Create(emailBox.Text);
            MessageBox.Show("Successful!");
            this.Close();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
