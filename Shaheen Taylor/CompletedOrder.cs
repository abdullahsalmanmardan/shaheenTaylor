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
    public partial class CompletedOrder : Form
    {
        db fn=new db();
        public CompletedOrder()
        {
            InitializeComponent();
        }

        private void CompletedOrder_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT Orders.orderid,Orders.orderdate,measurement.phoneNO,Orders.totalbill,Orders.mid,Orders.orderStatus,Orders.orderType,Orders.payment,Orders.paymentleft,Orders.deliverydate,measurement.collar,measurement.shoulder, measurement.sleeves, measurement.chest,measurement.waist,measurement.length,measurement.armhole,measurement.trouserlength ,measurement.bottom,measurement.sidePocket,measurement.frontPocket,measurement.shalwar,measurement.cuff,measurement.bazo,measurement.plate,measurement.platesize,measurement.daman,measurement.notes,measurement.price FROM Orders INNER JOIN measurement ON Orders.mid=measurement.mid and orderStatus='" + "clear" + "'";
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
