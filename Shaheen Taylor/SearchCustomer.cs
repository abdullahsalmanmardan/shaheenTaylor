using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen_Taylor
{
    public partial class SearchCustomer : Form
    {
        db fn = new db();
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            string query = "select * from customer";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        // search by customer name
        private void btnContact_Click(object sender, EventArgs e)
        {
            if(txtcontactSearch.Text.Length==11)
            {
                string query = "select * from customer where phoneNo='" + txtcontactSearch.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                txtcontactSearch.Clear();
            }
            else
            {
                MessageBox.Show("Enter the valid phone no of 11 digit");
            }
        }
        // search customer byname
        private void btnname_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >0)
            {
                string query = "select * from customer where name='" + textBox1.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter the valid phone no of 11 digit");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string query = "select * from customer";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
