using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 :Form
    {
        PhoneBook phone_book = new PhoneBook();
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void deleteUserButton_Click (object sender, EventArgs e)
        {
            phone_book.RemoveUser(dataGridView1.SelectedRows[0].Index, dataGridView1);
        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void fillTableButton_Click (object sender, EventArgs e)
        {
            
            PhoneBookLoader.Load(phone_book, loadFileTextBox.Text, dataGridView1);
        }

        private void findForNameButton_Click (object sender, EventArgs e)
        {
            phone_book.FindForName(nameTextBox.Text, dataGridView1);
        }

        private bool CheckNumber (string number, string name)
        {
            try
            {
                if (number.Length != 14)
                {
                    throw new Exception("Вы ввели не все символы в номере");
                }
                if (number[0] != '(')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[4] != ')')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[8] != '-')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[11] != '-')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (name.Length == 0)
                    throw new Exception("Вы не ввели имя");
                return true;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void exportButton_Click (object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.Length != 0)
                PhoneBookLoader.Save(phone_book, fileNameTextBox.Text, dataGridView1);
            else
                MessageBox.Show("Вы не ввели имя файла");
        }

        private void addPersonButton_Click (object sender, EventArgs e)
        {
            if (CheckNumber(numberTextBox.Text, addNameTextBox.Text))
            {
                phone_book.AddUser(addNameTextBox.Text, numberTextBox.Text, dataGridView1);
            }
        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
