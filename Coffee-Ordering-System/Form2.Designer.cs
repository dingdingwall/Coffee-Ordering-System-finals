namespace Coffee_Ordering_System
{
    partial class Form2
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
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsprice = new System.Windows.Forms.TextBox();
            this.txtreorderpoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.txtstocksonhand = new System.Windows.Forms.TextBox();
            this.cbocategory = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dpexpirydate = new System.Windows.Forms.DateTimePicker();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.sales_masterTableAdapter1 = new Coffee_Ordering_System.dbconnectDataSet1TableAdapters.sales_masterTableAdapter();
            this.sales_masterTableAdapter2 = new Coffee_Ordering_System.dbconnectDataSet1TableAdapters.sales_masterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(93, 79);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 20);
            this.txtItemNo.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(93, 126);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 20);
            this.txtdescription.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(307, 305);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(406, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(500, 305);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selling Price";
            // 
            // txtsprice
            // 
            this.txtsprice.Location = new System.Drawing.Point(93, 176);
            this.txtsprice.Name = "txtsprice";
            this.txtsprice.Size = new System.Drawing.Size(100, 20);
            this.txtsprice.TabIndex = 9;
            // 
            // txtreorderpoint
            // 
            this.txtreorderpoint.Location = new System.Drawing.Point(93, 225);
            this.txtreorderpoint.Name = "txtreorderpoint";
            this.txtreorderpoint.Size = new System.Drawing.Size(100, 20);
            this.txtreorderpoint.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reorder Point";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unit of Measure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Expiry Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stocks on hand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Category";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(544, 82);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(100, 20);
            this.txtunit.TabIndex = 17;
            // 
            // txtstocksonhand
            // 
            this.txtstocksonhand.Location = new System.Drawing.Point(544, 173);
            this.txtstocksonhand.Name = "txtstocksonhand";
            this.txtstocksonhand.Size = new System.Drawing.Size(100, 20);
            this.txtstocksonhand.TabIndex = 19;
            // 
            // cbocategory
            // 
            this.cbocategory.Location = new System.Drawing.Point(544, 218);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(100, 20);
            this.cbocategory.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(688, 12);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Search";
            // 
            // dpexpirydate
            // 
            this.dpexpirydate.Location = new System.Drawing.Point(544, 123);
            this.dpexpirydate.Name = "dpexpirydate";
            this.dpexpirydate.Size = new System.Drawing.Size(200, 20);
            this.dpexpirydate.TabIndex = 23;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(2, 351);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(797, 184);
            this.dgvStock.TabIndex = 24;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sales_masterTableAdapter1
            // 
            this.sales_masterTableAdapter1.ClearBeforeFill = true;
            // 
            // sales_masterTableAdapter2
            // 
            this.sales_masterTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 534);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.dpexpirydate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.txtstocksonhand);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtreorderpoint);
            this.Controls.Add(this.txtsprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtItemNo);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsprice;
        private System.Windows.Forms.TextBox txtreorderpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.TextBox txtstocksonhand;
        private System.Windows.Forms.TextBox cbocategory;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpexpirydate;
        private System.Windows.Forms.DataGridView dgvStock;
        private dbconnectDataSet1TableAdapters.sales_masterTableAdapter sales_masterTableAdapter1;
        private dbconnectDataSet1TableAdapters.sales_masterTableAdapter sales_masterTableAdapter2;
    }
}