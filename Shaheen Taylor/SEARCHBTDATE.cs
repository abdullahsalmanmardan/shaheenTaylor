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
    public partial class SEARCHBTDATE : Form
    {
        db fn = new db();
        public SEARCHBTDATE()
        {
            InitializeComponent();
        }

        private void SEARCHBTDATE_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "pending" + "'";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsearchbydate_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and deliverydate='" + dateTimePicker1.Value.ToString() + "'";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
