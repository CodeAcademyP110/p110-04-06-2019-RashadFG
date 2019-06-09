using System;
using System.Windows.Forms;

namespace _07._06._19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            cmbCateqoryDefault.DataSource = Product.GetCategories();
            cmbCateqoryDefault.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region variables
            string product = txtProduct.Text.Trim();
            decimal qunatity = nmrcQunatity.Value;
            decimal price = nmrcPrice.Value;
            decimal discountPercent = nmrcDsicount.Value;
            string categoryName = cmbCateqoryDefault.Text;
            bool discount = chcHasDiscount.Checked;
            #endregion

            #region validation
            if (txtProduct.Text == string.Empty)
            {
                MessageBox.Show("Your product name is empty", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nmrcPrice.Value == 0)
            {
                MessageBox.Show("Please input product price", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nmrcQunatity.Value == 0)
            {
                MessageBox.Show("Please input product qunatity", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chcHasDiscount.Checked)
            {
                if (nmrcDsicount.Value == 0)
                {
                    MessageBox.Show("Please input product discount percent", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion

            #region Add Product
            Product pro = new Product(product, categoryName, price, qunatity, discount, discountPercent);
            Product.AddProduct(pro);
            Reset();

            dgwProduct.DataSource = null;
            dgwProduct.DataSource = Product.GetProducts();
            #endregion
        }

        #region Checked discount
        private void chcHasDiscount_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chcHasDiscount.Checked)
            {
                nmrcDsicount.Visible = true;
            }
            else
            {
                nmrcDsicount.Visible = false;
            }
        }
        #endregion

        #region resert
        private void Reset()
        {
            txtProduct.Text = string.Empty;
            nmrcPrice.Value = nmrcQunatity.Value = nmrcDsicount.Value = 0;
        }
        #endregion

        #region click dprduct->delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        #endregion


    }
}
