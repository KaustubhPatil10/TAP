using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Membership;
using Catalog;
using System.Runtime.Serialization.Formatters.Binary;

namespace WareHouseApp
{
    public partial class MainForm : Form
    {
        // List to hold all Product collections as Inventory
        private List<Product> allProducts = new List<Product>();

        public MainForm()
        {
            InitializeComponent(); // code is written in seperate designer.cs file
            
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        // Event Handler
       
        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string FileName = dlg.FileName;
                FileStream stream = new FileStream(FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.allProducts = (List<Product>)bf.Deserialize(stream);
                stream.Close();
            }
            Display();
            //Bind List to DataGridView.
            this.dataProductsGridView.DataSource = null;
            this.dataProductsGridView.DataSource = allProducts;
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;  // get the name of the file selected
                FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, allProducts);
                stream.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OnToolsSignIn(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OnInsertProduct(object sender, EventArgs e)
        {

            //Get data from controls and store to variables.

            int id = int.Parse(this.txtProductID.Text);
            string title = this.txtProductTitle.Text;
            string description = this.txtProductDescription.Text;
            float unitPrice = float.Parse(this.txtUnitPrice.Text);
            int quantity = int.Parse(this.txtQuantity.Text);

            //create instance of Product based on data received.

            Product theProduct = new Product
            {
                ID = id,
                Title = title,
                Description = description,
                UnitPrice = unitPrice,
                Quantity = quantity
            };


            //populating data into GridView
            //Add product data into list
            this.allProducts.Add(theProduct);

            //Bind List to DataGridView.
            this.dataProductsGridView.DataSource = null;
            this.dataProductsGridView.DataSource = allProducts;

        }


        private int current = 0;
        private void OnFirst(object sender, EventArgs e)
        {
            this.current = 0;
            Display();
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            if(this.current != 0)
            this.current = current - 1;
            Display();
        }

        private void OnNext(object sender, EventArgs e)
        {
            if(this.current != allProducts.Count)
            this.current = current + 1;
            Display();
        }

        private void OnLast(object sender, EventArgs e)
        {
            this.current = allProducts.Count - 1;
            Display();
        }

        private void Display()
        {
            Product theProduct = allProducts[current];
            this.txtProductID.Text = theProduct.ID.ToString();
            this.txtProductTitle.Text = theProduct.Title.ToString();
            this.txtProductDescription.Text = theProduct.Description.ToString();
            this.txtUnitPrice.Text = theProduct.UnitPrice.ToString();
            this.txtQuantity.Text = theProduct.Quantity.ToString();
        }
    }
}
