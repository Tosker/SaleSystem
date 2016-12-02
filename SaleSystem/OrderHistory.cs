using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleSystem
{
    public class OrderHistory
    {
        private DataManager OrderData;
        private DataManager PurchaseData;

        public List<Purchase> PurchasedItems;
        public List<Order> CustomerOrders;
        private string _CustomerId;

        public OrderHistory(string customerId)
        {
            OrderData = new DataManager();
            PurchaseData = new DataManager();

            PurchaseData.RetrieveAll("Purchases");
            OrderData.RetrieveAll("Orders");

            _CustomerId = customerId;
            LoadAllOrders();
        }
    
        private void LoadAllOrders()
        {
            CustomerOrders = new List<Order>();

            for (int i = 0; i < OrderData.Count; i++)
            {
                if(OrderData.ValueAsString(i,1) == _CustomerId)
                {
                    Order tempHolder   = new Order();

                    tempHolder.orderid      = Convert.ToInt32(OrderData.Items[i].ItemArray[0]);
                    tempHolder.customerid   = OrderData.Items[i].ItemArray[1].ToString();
                    tempHolder.purchasedate = OrderData.Items[i].ItemArray[2].ToString();

                    CustomerOrders.Add(tempHolder);
                }
            }
        }

        public void LoadAllItems(int orderid)
        {
            PurchasedItems = new List<Purchase>();

            for (int i = 0; i < PurchaseData.Count; i++)
            {
                if (PurchaseData.ValueAsString(i, 0) == orderid.ToString())
                {
                    Purchase tempHolder = new Purchase();

                    tempHolder.orderid      = Convert.ToInt32(PurchaseData.Items[i].ItemArray[0]);
                    tempHolder.productname  = PurchaseData.Items[i].ItemArray[1].ToString();
                    tempHolder.productprice = Convert.ToDouble(PurchaseData.Items[i].ItemArray[3]);
                    tempHolder.productid    = Convert.ToInt32(PurchaseData.Items[i].ItemArray[4]);

                    PurchasedItems.Add(tempHolder);
                }
            }
        }
    }

    public class Purchase
    {
        public int orderid;
        public string productname;
        public double productprice;
        public int productid;
    }

    public class Order
    {
        public int orderid;
        public string customerid;
        public string purchasedate;
    }
}
