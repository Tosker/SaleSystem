using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleSystem
{
    class Pricebook
    {
        public List<Product> Merchandise;
        private DataManager PricebookData;
        private ConnectionManager Database;
        

        public Pricebook()
        {
            Merchandise = new List<Product>();
            PricebookData = new DataManager();
            Database = new ConnectionManager();

            PricebookData.RetrieveAll("Products");
            PricebookData.PrimaryIndex = 0;
            LoadProducts();
        }

        private void LoadProducts()
        {
            Product tempProduct;
            for (int i = 0; i < PricebookData.Count; i ++)
            {
                tempProduct = new Product();
                tempProduct.Id       = Convert.ToInt32(PricebookData.Items[i].ItemArray[0]);
                tempProduct.Name     = PricebookData.Items[i].ItemArray[1].ToString();
                tempProduct.Price    = Convert.ToDouble(PricebookData.Items[i].ItemArray[2]);
                tempProduct.Category = PricebookData.Items[i].ItemArray[3].ToString();
                Merchandise.Add(tempProduct);
            }
        }

        public void CreateProduct(Product newProduct)
        {
            Database.AddToPricebook(newProduct);
        }

        public void RemoveProduct(Product newProduct)
        {
            Database.RemoveFromPricebook(newProduct.Id);
        }

        public void EditProduct(Product newProduct)
        {
            Database.EditToPricebook(newProduct.Id, newProduct.Name, newProduct.Price, newProduct.Category);
        }

        public void Refresh()
        {
            Merchandise = new List<Product>();
            PricebookData = new DataManager();

            PricebookData.RetrieveAll("Products");
            PricebookData.PrimaryIndex = 0;
            LoadProducts();
        }
    }

    class Product
    {
        private int _Id;
        private double _Price;
        private string _Name;
        private string _Category;

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Category { get { return _Category; } set { _Category = value; } }
        public double Price { get { return _Price; } set { _Price = value; } }
    }
}
