using System;
using System.Windows.Forms;

namespace _07._06._19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbProducts1.Items.Clear();

            foreach (var pro in Product.GetProducts())
            {
                cmbProducts1.Items.Add(pro.Id+" "+pro.Name);
            }
            cmbProducts1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedID = cmbProducts1.Text.Substring(0, 4);
            Product.DeleteProduct(SelectedID);
            cmbProducts1.Items.Clear();

            foreach (var pro in Product.GetProducts())
            {
                cmbProducts1.Items.Add(pro.Id + " " + pro.Name);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}

