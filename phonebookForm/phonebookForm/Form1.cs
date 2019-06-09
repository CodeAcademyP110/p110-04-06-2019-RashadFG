using System;
using System.Windows.Forms;

namespace phonebookForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in PhoneBook.GetinternationalCode())
            {
                comboBox1.Items.Add(item.Code);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Variables
            string name = txtNameBox.Text;
            string code = comboBox1.Text;
            string num = txtNumber.Text.Replace(" ", "");
            string number = code + txtNumber.Text.Replace(" ", "");

            #endregion

            #region Validation
            if (name == string.Empty)
            {
                MessageBox.Show("Name is  empty", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (num == string.Empty)
            {
                MessageBox.Show("Number is  empty", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (num.Length != 7)
            {
                MessageBox.Show("Your number must be seven chacaracter," +
                                "Please input valid Number", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var n in num)
            {
                if (n > 'A' && n < 'Z' || n > 'a' && n < 'z')
                {
                    MessageBox.Show("Number is  not valid", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion

            #region Add properties
            PhoneBook phonebook = new PhoneBook()
            {
                Name = name,
                Number = number
            };

            PhoneBook.AddMembers(phonebook);
            Resert();

            dtgArea.DataSource = null;
            dtgArea.DataSource = PhoneBook.GetMembers();
            #endregion
        }

        #region reset
        private void Resert()
        {
            txtNameBox.Text = string.Empty;
            txtNumber.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }
        #endregion

    }
}
