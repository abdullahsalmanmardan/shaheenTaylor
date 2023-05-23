using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shaheen_Taylor
{
    public partial class PendingOrder : Form
    {
        db fn=new db();
        public PendingOrder()
        {
            InitializeComponent();
        }

        private void PendingOrder_Load(object sender, EventArgs e)
        {
            //string query1 = "SELECT * from Orders where orderStatus='" + "pending" + "'";
            //DataSet ds = fn.getData(query1);
            //dataGridView1.DataSource = ds.Tables[0];
            string query1 = "SELECT Orders.orderid,Orders.orderdate,measurement.phoneNO,Orders.totalbill,Orders.mid,Orders.orderStatus,Orders.orderType,Orders.payment,Orders.paymentleft,Orders.deliverydate,measurement.collar,measurement.shoulder, measurement.sleeves, measurement.chest,measurement.waist,measurement.length,measurement.armhole,measurement.trouserlength ,measurement.bottom,measurement.sidePocket,measurement.frontPocket,measurement.shalwar,measurement.cuff,measurement.bazo,measurement.plate,measurement.platesize,measurement.daman,measurement.notes,measurement.price FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "pending" + "'";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];

            string query2 = "select * from customer"; 
            DataSet ds1 = fn.getData(query2);
            dataGridView2.DataSource = ds1.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string orderid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbalance.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtorderid.Text= orderid;
            }
            catch { }
           
        }

        private void btnupdateorder_Click(object sender, EventArgs e)
        {
            string query= "UPDATE orders SET orderStatus = '"+"clear"+"' where orderid='"+txtorderid.Text+"'";
            fn.setData(query, $"order with id {txtorderid.Text} is completed");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            if(txtcontactSearch.Text.Length > 0)
            {
                string query = "select mid from measurement where phoneNo='" + txtcontactSearch.Text + "'";
                DataSet ds = fn.getData(query);
                string mid = "";
                try
                {
                    mid = ds.Tables[0].Rows[0][0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ڈیٹا نہیں ملا");
                    return;
                }
                string query1 = "SELECT Orders.orderid,Orders.orderdate,measurement.phoneNO,Orders.totalbill,Orders.mid,Orders.orderStatus,Orders.orderType,Orders.payment,Orders.paymentleft,Orders.deliverydate,measurement.collar,measurement.shoulder, measurement.sleeves, measurement.chest,measurement.waist,measurement.length,measurement.armhole,measurement.trouserlength ,measurement.bottom,measurement.pocketType,measurement.shalwar,measurement.cuff,measurement.bazo,measurement.plate,measurement.platesize,measurement.daman,measurement.notes,measurement.price FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "pending" + "' and measurement.mid='" + mid+"'";
                DataSet dss = fn.getData(query1);
                dataGridView1.DataSource = dss.Tables[0];

                string Query= "select * from customer where phoneNo='" + txtcontactSearch.Text + "'";
                DataSet dss1 = fn.getData(Query);
                dataGridView2.DataSource = dss1.Tables[0];

            }
            else
            {
                MessageBox.Show("Enter the no first to search");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Orders.orderid,Orders.orderdate,measurement.phoneNO,Orders.totalbill,Orders.mid,Orders.orderStatus,Orders.orderType,Orders.payment,Orders.paymentleft,Orders.deliverydate,measurement.collar,measurement.shoulder, measurement.sleeves, measurement.chest,measurement.waist,measurement.length,measurement.armhole,measurement.trouserlength ,measurement.bottom,measurement.sidePocket,measurement.frontPocket,measurement.shalwar,measurement.cuff,measurement.bazo,measurement.plate,measurement.platesize,measurement.daman,measurement.notes,measurement.price FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "pending" + "'";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
            txtbalance.Clear();
            txtcontactSearch.Clear();
            txtorderid.Clear();
        }

        private void seachcustid_Click(object sender, EventArgs e)
        {
            string contact = "";
            if (customerid.Text.Length > 0)
            {
                string query2 = "select phoneNo from customer where customerId='" + customerid.Text + "'";
                DataSet ds11 = fn.getData(query2);
              
                try
                {
                    contact = ds11.Tables[0].Rows[0][0].ToString(); 

                }
                catch(Exception ex)
                {
                    MessageBox.Show("ڈیٹا نہیں ملا");
                    return;
                }
               
                string query = "select mid from measurement where phoneNo='" +contact + "'";
                DataSet ds = fn.getData(query);
                string mid = "";
                try
                {
                    mid = ds.Tables[0].Rows[0][0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ڈیٹا نہیں ملا");
                    return;
                }
               
                string query1 = "SELECT Orders.orderid,Orders.orderdate,measurement.phoneNO,Orders.totalbill,Orders.mid,Orders.orderStatus,Orders.orderType,Orders.payment,Orders.paymentleft,Orders.deliverydate,measurement.collar,measurement.shoulder, measurement.sleeves, measurement.chest,measurement.waist,measurement.length,measurement.armhole,measurement.trouserlength ,measurement.bottom,measurement.sidePocket,measurement.frontPocket,measurement.shalwar,measurement.cuff,measurement.bazo,measurement.plate,measurement.platesize,measurement.daman,measurement.notes,measurement.price FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "pending" + "' and measurement.mid='" + mid + "'";
                DataSet dss = fn.getData(query1);
                dataGridView1.DataSource = dss.Tables[0];
                string Query = "select * from customer where customerId='" + customerid.Text + "'";
                DataSet dss1 = fn.getData(Query);
                dataGridView2.DataSource = dss1.Tables[0];
            }
            else
            {
                MessageBox.Show("تلاش کرنے کے لئے کسٹمر آئی ڈی درج کریں");
            }
        }
    }
}
