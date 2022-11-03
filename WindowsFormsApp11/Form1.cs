using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        Queue<Customer> queue;
        public Form1()
        {
            InitializeComponent();
            queue = new Queue<Customer>();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            Customer user = new Customer(name);
            queue.Enqueue(user);
            ShowUser();
            textBox1.Text = String.Empty;
        }
        private void ShowUser()
        {
            listBox1.Items.Clear();
            foreach (var item in queue)
            {
                listBox1.Items.Add(item.Name);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Customer user = queue.Dequeue();
            MessageBox.Show("Чек №");
            ShowUser();
        }
    }
}
