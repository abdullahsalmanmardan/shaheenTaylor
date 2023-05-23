namespace Shaheen_Taylor
{
    partial class SearchCustomer
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
            this.btnContact = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnname = new System.Windows.Forms.Button();
            this.txtcontactSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnname);
            this.panel1.Controls.Add(this.txtcontactSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 515);
            this.panel1.TabIndex = 0;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.White;
            this.btnContact.BackgroundImage = global::Shaheen_Taylor.Properties.Resources.search;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.Location = new System.Drawing.Point(587, 129);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(30, 31);
            this.btnContact.TabIndex = 11;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 190);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(0, 322);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(787, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(787, 322);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.Color.White;
            this.btnname.BackgroundImage = global::Shaheen_Taylor.Properties.Resources.search;
            this.btnname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnname.Location = new System.Drawing.Point(587, 72);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(30, 31);
            this.btnname.TabIndex = 8;
            this.btnname.UseVisualStyleBackColor = false;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // txtcontactSearch
            // 
            this.txtcontactSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontactSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcontactSearch.ForeColor = System.Drawing.Color.White;
            this.txtcontactSearch.Location = new System.Drawing.Point(287, 129);
            this.txtcontactSearch.Name = "txtcontactSearch";
            this.txtcontactSearch.Size = new System.Drawing.Size(270, 35);
            this.txtcontactSearch.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Customer Contact";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(287, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 35);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Customer Data";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::Shaheen_Taylor.Properties.Resources.sync_64px;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnrefresh.Location = new System.Drawing.Point(672, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(72, 69);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 515);
            this.Name = "SearchCustomer";
            this.Text = "SearchCustomer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnContact;
        private DataGridView dataGridView1;
        private Button btnname;
        private TextBox txtcontactSearch;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button btnrefresh;
    }
}