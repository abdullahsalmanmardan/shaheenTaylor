namespace Shaheen_Taylor
{
    partial class PendingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.seachcustid = new System.Windows.Forms.Button();
            this.customerid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.txtcontactSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdateorder = new System.Windows.Forms.Button();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.seachcustid);
            this.panel1.Controls.Add(this.customerid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.txtcontactSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.txtbalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnupdateorder);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 515);
            this.panel1.TabIndex = 0;
            // 
            // seachcustid
            // 
            this.seachcustid.BackColor = System.Drawing.Color.White;
            this.seachcustid.BackgroundImage = global::Shaheen_Taylor.Properties.Resources.search;
            this.seachcustid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seachcustid.Location = new System.Drawing.Point(594, 152);
            this.seachcustid.Name = "seachcustid";
            this.seachcustid.Size = new System.Drawing.Size(30, 31);
            this.seachcustid.TabIndex = 17;
            this.seachcustid.UseVisualStyleBackColor = false;
            this.seachcustid.Click += new System.EventHandler(this.seachcustid_Click);
            // 
            // customerid
            // 
            this.customerid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerid.ForeColor = System.Drawing.Color.White;
            this.customerid.Location = new System.Drawing.Point(308, 151);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(270, 35);
            this.customerid.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "کسٹمر آئی ڈی کے ذریعہ تلاش کریں";
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.White;
            this.btnContact.BackgroundImage = global::Shaheen_Taylor.Properties.Resources.search;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.Location = new System.Drawing.Point(498, 109);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(30, 31);
            this.btnContact.TabIndex = 14;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // txtcontactSearch
            // 
            this.txtcontactSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontactSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcontactSearch.ForeColor = System.Drawing.Color.White;
            this.txtcontactSearch.Location = new System.Drawing.Point(213, 105);
            this.txtcontactSearch.Name = "txtcontactSearch";
            this.txtcontactSearch.Size = new System.Drawing.Size(270, 35);
            this.txtcontactSearch.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "نمبر کے لحاظ سے تلاش";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::Shaheen_Taylor.Properties.Resources.sync_64px;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnrefresh.Location = new System.Drawing.Point(600, 3);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(72, 69);
            this.btnrefresh.TabIndex = 8;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.ForeColor = System.Drawing.Color.Red;
            this.txtbalance.Location = new System.Drawing.Point(335, 51);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(99, 23);
            this.txtbalance.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(199, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ادا کی جانے والی رقم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data records";
            // 
            // btnupdateorder
            // 
            this.btnupdateorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupdateorder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdateorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdateorder.Location = new System.Drawing.Point(452, 46);
            this.btnupdateorder.Name = "btnupdateorder";
            this.btnupdateorder.Size = new System.Drawing.Size(142, 31);
            this.btnupdateorder.TabIndex = 4;
            this.btnupdateorder.Text = "آرڈر مکمل کریں";
            this.btnupdateorder.UseVisualStyleBackColor = false;
            this.btnupdateorder.Click += new System.EventHandler(this.btnupdateorder_Click);
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(116, 51);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(77, 23);
            this.txtorderid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Id ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 197);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(0, 315);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(792, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(945, 315);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(308, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order In Queue";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(678, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(272, 157);
            this.dataGridView2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(678, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "کسٹمر ریکارڈ";
            // 
            // PendingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 515);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 515);
            this.Name = "PendingOrder";
            this.Text = "PendingOrder";
            this.Load += new System.EventHandler(this.PendingOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btnupdateorder;
        private TextBox txtorderid;
        private Label label2;
        private TextBox txtbalance;
        private Label label4;
        private Button btnrefresh;
        private Button btnContact;
        private TextBox txtcontactSearch;
        private Label label5;
        private Button seachcustid;
        private TextBox customerid;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
    }
}