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
    public partial class PosForm : Form
    {
        DataManager shoppingManager;
        ConnectionManager Database;

        List<Item> shoppingCart;
        private bool isSale;
        private string UserId;
        private double total = 0.00;

        public PosForm(string UserId)
        {
            InitializeComponent();
            shoppingManager = new DataManager();
            shoppingCart = new List<Item>();
            Database = new ConnectionManager();
            this.UserId = UserId;
        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            int orderID = Database.InitializeOrder(UserId, DateTime.Now.ToString());
            foreach (Item i in shoppingCart)
            {
                Database.FinalizeOrder(orderID, i);
            }
            this.Close();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            shoppingManager.RetrieveAll("Products");
            LoadProduct();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(typeCombo.SelectedIndex == 0)
            {
                isSale = true;
            }
            else
            {
                isSale = false;
            }
            RingUpProduct(Convert.ToInt32(productView.SelectedItems[0].SubItems[3].Text));
        }

        private void LoadProduct()
        {
            foreach(var p in shoppingManager.Items)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.ItemArray[1].ToString();
                item.SubItems.Add(p.ItemArray[3].ToString());
                item.SubItems.Add(p.ItemArray[2].ToString());
                item.SubItems.Add(p.ItemArray[0].ToString());

                productView.Items.Add(item);
            }
        }

        private void RingUpProduct(int id)
        {
            Item tempMerch = new Item();
            tempMerch.ItemName = productView.SelectedItems[0].Text;
            tempMerch.ItemCategory = productView.SelectedItems[0].SubItems[1].ToString();
            tempMerch.ItemPrice = Convert.ToDouble(productView.SelectedItems[0].SubItems[2].Text);
            tempMerch.ItemID = Convert.ToInt32(productView.SelectedItems[0].SubItems[3].Text);
            shoppingCart.Add(tempMerch);

            ListViewItem tempItem = new ListViewItem();
            tempItem.Text = tempMerch.ItemName;
            if(isSale)
            {
                tempItem.SubItems.Add("Sale");
                tempItem.SubItems.Add(tempMerch.ItemPrice.ToString());
            }
            else
            {
                tempItem.SubItems.Add("Refund");
                tempItem.SubItems.Add("- " + tempMerch.ItemPrice.ToString());
            }

            total += tempMerch.ItemPrice;
            totalLbl.Text = "Total: " + total.ToString();
            TransactionView.Items.Add(tempItem);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            total -= shoppingCart[TransactionView.SelectedItems[0].Index].ItemPrice;
            totalLbl.Text = "Total: " + total.ToString();
            shoppingCart.RemoveAt(TransactionView.SelectedItems[0].Index);
            TransactionView.SelectedItems[0].Remove();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            productView.Items.Clear();
            if (searchBox.Text != "")
            {
                foreach (var p in shoppingManager.Items)
                {
                    if (p.ItemArray[1].ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = p.ItemArray[1].ToString();
                        item.SubItems.Add(p.ItemArray[3].ToString());
                        item.SubItems.Add(p.ItemArray[2].ToString());
                        item.SubItems.Add(p.ItemArray[0].ToString());

                        productView.Items.Add(item);
                    }
                }
            }
            else
            {
                LoadProduct();
            }
        }

        private void TransactionView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemID { get; set; }
        public string ItemCategory { get; set; }
        public bool isSale { get; set; }
    }
}
