﻿namespace Drug_Store_Manager {
    partial class Sell {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.product_grid_view = new System.Windows.Forms.DataGridView();
            this.employee_name_out = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contact_no_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_in = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_product_button = new System.Windows.Forms.Button();
            this.big_label = new System.Windows.Forms.Label();
            this.purchase_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Employee:";
            // 
            // product_grid_view
            // 
            this.product_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid_view.Location = new System.Drawing.Point(17, 26);
            this.product_grid_view.Name = "product_grid_view";
            this.product_grid_view.ReadOnly = true;
            this.product_grid_view.RowHeadersVisible = false;
            this.product_grid_view.Size = new System.Drawing.Size(748, 242);
            this.product_grid_view.TabIndex = 55;
            this.product_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_grid_view_CellMouseDoubleClick);
            // 
            // employee_name_out
            // 
            this.employee_name_out.AutoSize = true;
            this.employee_name_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name_out.Location = new System.Drawing.Point(171, 42);
            this.employee_name_out.Name = "employee_name_out";
            this.employee_name_out.Size = new System.Drawing.Size(91, 19);
            this.employee_name_out.TabIndex = 64;
            this.employee_name_out.Text = "Employee:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contact_no_in);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.name_in);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(414, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 131);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // contact_no_in
            // 
            this.contact_no_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_in.Location = new System.Drawing.Point(120, 70);
            this.contact_no_in.Name = "contact_no_in";
            this.contact_no_in.Size = new System.Drawing.Size(243, 27);
            this.contact_no_in.TabIndex = 66;
            this.contact_no_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Phone no. :";
            // 
            // name_in
            // 
            this.name_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(120, 36);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(243, 27);
            this.name_in.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employee_name_out);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.date_in);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 131);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Date";
            // 
            // date_in
            // 
            this.date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_in.Location = new System.Drawing.Point(175, 73);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(199, 27);
            this.date_in.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.product_grid_view);
            this.groupBox1.Controls.Add(this.add_product_button);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 313);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // add_product_button
            // 
            this.add_product_button.BackColor = System.Drawing.Color.White;
            this.add_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_button.Location = new System.Drawing.Point(643, 274);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(122, 30);
            this.add_product_button.TabIndex = 56;
            this.add_product_button.Text = "Add Product";
            this.add_product_button.UseVisualStyleBackColor = false;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.Location = new System.Drawing.Point(12, 9);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(74, 41);
            this.big_label.TabIndex = 72;
            this.big_label.Text = "Sell";
            // 
            // purchase_button
            // 
            this.purchase_button.BackColor = System.Drawing.Color.White;
            this.purchase_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_button.Location = new System.Drawing.Point(330, 522);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(159, 50);
            this.purchase_button.TabIndex = 70;
            this.purchase_button.Text = "Sell";
            this.purchase_button.UseVisualStyleBackColor = false;
            this.purchase_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(819, 586);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.big_label);
            this.Controls.Add(this.purchase_button);
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_grid_view;
        private System.Windows.Forms.Label employee_name_out;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox contact_no_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_in;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.Button purchase_button;
    }
}