using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    public class Product
    {
        private string title;
        private string description;
        private int quantity;
        private float unitPrice;
        private int id;

        //readonly i.e = get{} property for ID
        public int ID
        {
            get { return id; }
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }

        public float UnitPrice
        {
            get { return unitPrice; }
            set { this.unitPrice = value; }
        }

        public Product()
        {

        }
        
        public Product(int id, string title, string description, int quantity, float unitPrice)
        {
            this.id = id; // id is not written in this.ID bcoz there is only get{} function written in it. 
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        ~Product()
        {
            // Destructor - to Deinitialize object instance before getting destroyed.
        }


        //Object
        //object both are same
        public override string ToString()
        {
            //return base.ToString();
            return this.ID + " " + this.Title + " " + this.Description + " " + this.Quantity + " " + this.UnitPrice;
        }
    }
}
