using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections;

namespace Shaheen_Taylor
{
    public partial class Measurement : Form
    {

        string contactNO = "";
        db fn = new db();
        int AddNewSize = 0;
        public Measurement()
        {
            InitializeComponent();
        }

        private bool checkIfNumberExist(string query1)
        {
            bool ifExist = false;

            DataSet ds = fn.getData(query1);

            //if table contain no value 
            if (ds.Tables[0].Rows.Count == 0)
            {
                ifExist = true;
            }
            // return false if found
            else
            {
                ifExist = false;
            }
            return ifExist;
        }

        private void Measurement_Load(object sender, EventArgs e)
        {
            txttotalbill.ReadOnly = true;
            string[] value1 = { "debit", "credit" };
            cbordertype.DataSource = value1;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string PocketRadio = "";
            string sidePocket = "";
            string shalwarZip = "";
            string cuff = "";
            string bazo = "";
            string colar = "";
            string plate = "";
            string plateSize = "";
            string daman = "";
            if (radioButton1.Checked)
            {
                PocketRadio = "front pocket";
            }
            if (radioButton2.Checked)
            {
                sidePocket = "side pocket";
            }

            // radio button for shalwar
            if (radioButton4.Checked)
            {
                shalwarZip = "zip ";
            }
            if (radioButton3.Checked)
            {
                shalwarZip = "sada";
            }

            // radio button for cuff
            if (radioButton6.Checked)
            {
                cuff = "gol";
            }
            if (radioButton5.Checked)
            {
                cuff = "choras";
            }

            // radio buttn for bazo
            if (radioButton8.Checked)
            {
                bazo = "gol bazo";
            }
            if (radioButton7.Checked)
            {
                bazo = "aghani bazo";
            }
            if (radioButton10.Checked)
            {
                bazo = "dar bazo";
            }
            if (radioButton9.Checked)
            {
                bazo = "modi";
            }
            if (radioButton12.Checked)
            {
                bazo = "off bazo";
            }
            if (radioButton11.Checked)
            {
                bazo = "menda";
            }

            // collar size
            if (radioButton18.Checked)
            {
                colar = "sherwani";
            }
            if (radioButton17.Checked)
            {
                colar = "choras";
            }
            if (radioButton16.Checked)
            {
                colar = "gol";
            }
            if (radioButton15.Checked)
            {
                colar = "cut collar";
            }

            // plate 
            if (radioButton20.Checked)
            {
                plate = "awami";
            }
            if (radioButton19.Checked)
            {
                plate = "irani";
            }

            // plate size
            if (radioButton14.Checked)
            {
                plateSize = "qanta";
            }

            //daman 
            if (radioButton13.Checked)
            {
                daman = "gol";
            }
            if (radioButton21.Checked)
            {
                daman = "choras";
            }

            string phoneNo = txtcustomernumber.Text;
            string name=txtcustomername.Text;
            string address=txtcustomeraddress.Text;
            string collar = txtcollarsize.Text;
            string shoulder=txtshouldersize.Text;
            string sleeve=txtsleevesize.Text;
            string chest=txtchestsize.Text;
            string waist=txtwaistsize.Text;
            string length=txtlength.Text;
            string armhole = txtarmhole.Text;
            string trouserLength=txttrouserlength.Text;
            string trouserBottom=txttrouserbottom.Text;
            string pricePerSuit=txtpricepersuit.Text;   
            string quantity=txtquantity.Text;
            
            string orderType = cbordertype.SelectedItem.ToString();
            string notes = txtinstructions.Text;
            if ( phoneNo.Length<11)
            {
                MessageBox.Show(" 11 ہندسوں کا فون نمبر درج کریں");
                return;
            }
            
            if ( AddNewSize == 0 )
            {
                string incomingData = quantity;
                int parsedResult;

                if (int.TryParse(incomingData, out parsedResult))
                {
                    //do something with the data. 
                }
                else
                {
                    MessageBox.Show("تعداد میں نمبر درج کریں");
                    return;
                }
                string incomingData1 = pricePerSuit;
                int parsedResult1;

                if (int.TryParse(incomingData1, out parsedResult1))
                {
                    
                }
                else
                {
                    MessageBox.Show("Enter the price per suit value in numbers");
                    return;
                }
                string incomingData2 = txtpayment.Text;
                int parsedResult2;

                if (int.TryParse(incomingData2, out parsedResult2))
                {
                    //do something with the data. 
                }
                else
                {
                    MessageBox.Show("Enter the payment value in numbers");
                    return;
                }
                txttotalbill.Text = Convert.ToString(parsedResult * parsedResult1);
                int totalBilVal = Convert.ToInt32(txttotalbill.Text);

                string paymentLeft = Convert.ToString(totalBilVal - parsedResult2);

                string noExist = "select * from customer where phoneNo='" + phoneNo + "'";
                bool numberExist = checkIfNumberExist(noExist);
                if (!numberExist)
                {
                    MessageBox.Show("کسٹمر پہلے سے موجود ہے");
                    return;
                }
                string query = "insert into customer (phoneNo,customerId,address,name) values('" + phoneNo + "','"+txtcustomerid.Text+"','" + address + "','" + name + "') ";
                fn.setData(query, "کسٹمر ریکارڈ شامل کیا گیا");


                string query1 = "insert into measurement (collar,shoulder, sleeves, chest,waist,length,armhole,trouserlength ,bottom,frontPocket,sidePocket,shalwar,cuff,bazo,colar,plate,platesize,daman,notes,price,phoneNo ) values('" + collar + "','" + shoulder + "','" + sleeve + "','" + chest + "','" + waist + "','" + length + "','" + armhole + "','" + trouserLength + "','" + trouserBottom + "','" + PocketRadio + "','"+sidePocket+"','" + shalwarZip + "','"+ cuff + "','"+ bazo + "','"+ colar + "','"+ plate + "','"+ plateSize + "','"+ daman +"','" + notes + "','" + pricePerSuit + "','" + phoneNo + "') ";
                fn.setData(query1, "پیمائش کا ریکارڈ شامل کیا گیا");

                string query2 = "select max(mid) from measurement";
                DataSet ds = fn.getData(query2);
                string midValue = ds.Tables[0].Rows[0][0].ToString();

                
                string query3 = "insert into orders (orderdate,quantity,totalbill,mid,orderStatus,orderType,payment,paymentleft,deliverydate) values('" + dateTimePicker1.Value.Date + "','" + quantity + "','" + txttotalbill.Text + "','" + midValue + "','" + "pending" + "','"+orderType+"' , '"+txtpayment.Text+"' ,'"+paymentLeft+"' , '" + dateTimePicker3.Value.Date + "') ";
                fn.setData(query3, $"آرڈر دیا گیا ہے اور آپ کا بل ہے {txttotalbill.Text}");
                clearTextFeild();
            }
            // jab user new order deny aay old size pe
            else if(AddNewSize == 1)
            {
                string query1 = "select mid from measurement where phoneNo ='" + phoneNo + "'";
                DataSet dss= fn.getData(query1);
                
                string midValue1 = dss.Tables[0].Rows[0][0].ToString();
                if (txtpayment.Text.Length > 0 && txtpricepersuit.Text.Length > 0 && txtquantity.Text.Length > 0)
                {
                    string query = "UPDATE measurement SET price = '" + txtpricepersuit.Text + "' where mid='" + midValue1 + "'";
                    fn.setData(query, "price per suit updated");
                    txttotalbill.Text = Convert.ToString(Int32.Parse(quantity) * Int32.Parse(pricePerSuit));

                    string paymentLeft = Convert.ToString(Convert.ToInt32(txttotalbill.Text) - Convert.ToInt32(txtpayment.Text));

                    string query3 = "insert into orders (orderdate,quantity,totalbill,mid,orderStatus,orderType,payment,paymentleft,deliverydate) values('" + dateTimePicker1.Value.Date + "','" + quantity + "','" + txttotalbill.Text + "','" + midValue1 + "','" + "pending" + "','" + orderType + "' , '" + txtpayment.Text + "' ,'" + paymentLeft + "' , '" + dateTimePicker3.Value.Date + "') ";

                    fn.setData(query3, $"آرڈر دیا گیا ہے اور آپ کا بل ہے {txttotalbill.Text}");

                    clearTextFeild();

                }
                else
                {
                    MessageBox.Show("Enter the price and quantity");
                }
                

            }
            // jab user ne new size b new ho mota ho gaya ha wo
            else if( AddNewSize ==2)
            {
                string query = "select mid from measurement where phoneNo ='" + phoneNo + "'";
                DataSet dss = fn.getData(query);

                string midValue1 = dss.Tables[0].Rows[0][0].ToString();
                string query1= "update measurement set collar='" + collar + "',shoulder='" + shoulder + "',sleeves='" + sleeve + "',chest='" + chest + "',waist='" + waist + "',length= '" + length + "',armhole='" + armhole + "',trouserlength='" + trouserLength + "' ,bottom='" + trouserBottom + "',frontPocket='" + PocketRadio + "',sidePocket='"+sidePocket+"',shalwar='" + shalwarZip + "',cuff='"+ cuff + "',bazo='"+ bazo + "',plate='"+ plate + "',platesize='"+ plateSize + "',daman='"+ daman +"',notes='" + notes + "',price='" + pricePerSuit + "'  where phoneNo='"+ contactNO +"'";
     
                fn.setData(query1, "پیمائش ریکارڈ کو اپ ڈیٹ کیا گیا ");

                string query2 = "select max(mid) from measurement";
                DataSet ds = fn.getData(query2);
                string midValue = ds.Tables[0].Rows[0][0].ToString();

                txttotalbill.Text = Convert.ToString(Int32.Parse(quantity) * Int32.Parse(pricePerSuit));

                string paymentLeft = Convert.ToString(Convert.ToInt32(txttotalbill.Text) - Convert.ToInt32(txtpayment.Text));

                string query3 = "insert into orders (orderdate,quantity,totalbill,mid,orderStatus,orderType,payment,paymentleft,deliverydate) values('" + dateTimePicker1.Value.Date + "','" + quantity + "','" + txttotalbill.Text + "','" + midValue + "','" + "pending" + "','" + orderType + "' , '" + txtpayment.Text + "' ,'" + paymentLeft + "' , '" + dateTimePicker3.Value.Date + "') ";

                fn.setData(query3, $"آرڈر دیا گیا ہے اور آپ کا بل ہےur bill is {txttotalbill.Text}");
                
                clearTextFeild();
            }
            
            else
            {
                MessageBox.Show("تمام فیلڈز درج کریں");
                return;
            }

        }

        // clear text
        public void clearTextFeild()
        {
            txtcustomernumber.Clear();
             txtcollarsize.Clear();
             txtshouldersize.Clear();
             txtsleevesize.Clear();
             txtchestsize.Clear();
             txtwaistsize.Clear();
             txtlength.Clear();
             txtarmhole.Clear();
             txttrouserlength.Clear();
             txttrouserbottom.Clear();
             txtpricepersuit.Clear();
             txtquantity.Clear();
             txtcustomeraddress.Clear();
             txtcustomername.Clear();
             txtcustomeraddress.Clear(); 
             txtinstructions.Clear();
            txttotalbill.Clear();
        }

        private void btnsearchcontact_Click(object sender, EventArgs e)
        {
            string contact = txtcustomernumber.Text;
            if(contact.Length<11 ) 
            {
                MessageBox.Show("ہندسوں کا فون نمبر درج کریں11 ");
                return;
                
            }
            string noExist = "select * from customer where phoneNo='" + contact + "'";
            bool numberExist = checkIfNumberExist(noExist);
            if (!numberExist)
            {
                DialogResult dialogResult = MessageBox.Show("کیا آپ نیا سائز شامل کرنا چاہتے ہیں یا نہیں؟ ", "کسٹمر پہلے سے موجود ہے", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    contactNO = contact;
                    AddNewSize = 2;
                }
                else if (dialogResult == DialogResult.No)
                {
                    contactNO = contact;
                    AddNewSize = 1;
                }
            }
        }

        private void txtpricepersuit_TextChanged(object sender, EventArgs e)
        {
            if(txtpricepersuit.Text.Length>0)
            {
                if(txtquantity.Text.Length>0)
                {
                    string incomingData = txtquantity.Text;
                    int parsedResult;

                    if (int.TryParse(incomingData, out parsedResult))
                    {
                        //do something with the data. 
                    }
                    else
                    {
                        MessageBox.Show("تعداد میں نمبر درج کریں");
                        return;
                    }
                    string incomingData1 = txtpricepersuit.Text;
                    int parsedResult1;

                    if (int.TryParse(incomingData1, out parsedResult1))
                    {
                        //do something with the data. 
                    }
                    else
                    {
                        MessageBox.Show("تعداد میں نمبر درج کریں");
                        return;
                    }

                    txttotalbill.Text = Convert.ToString(parsedResult * parsedResult1);

                }
               
            }
        }
    }

}
