﻿
namespace EliteElectronics
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bidTb = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.ProductlistDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.addtobillBtn = new System.Windows.Forms.Button();
            this.PpriceTb = new System.Windows.Forms.TextBox();
            this.clientNameTb = new System.Windows.Forms.TextBox();
            this.PquantityTb = new System.Windows.Forms.TextBox();
            this.PtitleTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.snameLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductlistDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bidTb);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.TotalLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.billDGV);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ProductlistDGV);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.printBtn);
            this.panel2.Controls.Add(this.addtobillBtn);
            this.panel2.Controls.Add(this.PpriceTb);
            this.panel2.Controls.Add(this.clientNameTb);
            this.panel2.Controls.Add(this.PquantityTb);
            this.panel2.Controls.Add(this.PtitleTb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(218, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 513);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Bill Id";
            // 
            // bidTb
            // 
            this.bidTb.Font = new System.Drawing.Font("Bebas Neue Book", 12F);
            this.bidTb.Location = new System.Drawing.Point(67, 17);
            this.bidTb.Name = "bidTb";
            this.bidTb.Size = new System.Drawing.Size(80, 27);
            this.bidTb.TabIndex = 29;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EliteElectronics.Properties.Resources.exit1;
            this.pictureBox5.Location = new System.Drawing.Point(574, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(378, 252);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(59, 31);
            this.TotalLbl.TabIndex = 27;
            this.TotalLbl.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bill";
            // 
            // billDGV
            // 
            this.billDGV.AllowUserToAddRows = false;
            this.billDGV.AllowUserToDeleteRows = false;
            this.billDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDGV.BackgroundColor = System.Drawing.Color.White;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.billDGV.Location = new System.Drawing.Point(209, 52);
            this.billDGV.Name = "billDGV";
            this.billDGV.ReadOnly = true;
            this.billDGV.Size = new System.Drawing.Size(384, 197);
            this.billDGV.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "Product List";
            // 
            // ProductlistDGV
            // 
            this.ProductlistDGV.AllowUserToAddRows = false;
            this.ProductlistDGV.AllowUserToDeleteRows = false;
            this.ProductlistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductlistDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductlistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductlistDGV.Location = new System.Drawing.Point(7, 266);
            this.ProductlistDGV.Name = "ProductlistDGV";
            this.ProductlistDGV.ReadOnly = true;
            this.ProductlistDGV.Size = new System.Drawing.Size(290, 223);
            this.ProductlistDGV.TabIndex = 21;
            this.ProductlistDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductlistDGV_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label12.Location = new System.Drawing.Point(96, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label11.Location = new System.Drawing.Point(7, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Client Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label9.Location = new System.Drawing.Point(101, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Quantity";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Black;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Bebas Neue Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(106, 180);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(57, 30);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Black;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Bebas Neue Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(380, 286);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(57, 30);
            this.printBtn.TabIndex = 14;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // addtobillBtn
            // 
            this.addtobillBtn.BackColor = System.Drawing.Color.Black;
            this.addtobillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtobillBtn.Font = new System.Drawing.Font("Bebas Neue Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtobillBtn.ForeColor = System.Drawing.Color.White;
            this.addtobillBtn.Location = new System.Drawing.Point(16, 180);
            this.addtobillBtn.Name = "addtobillBtn";
            this.addtobillBtn.Size = new System.Drawing.Size(79, 30);
            this.addtobillBtn.TabIndex = 13;
            this.addtobillBtn.Text = "Add to bill";
            this.addtobillBtn.UseVisualStyleBackColor = false;
            this.addtobillBtn.Click += new System.EventHandler(this.addtobillBtn_Click);
            // 
            // PpriceTb
            // 
            this.PpriceTb.Enabled = false;
            this.PpriceTb.Font = new System.Drawing.Font("Bebas Neue Book", 12F);
            this.PpriceTb.Location = new System.Drawing.Point(100, 138);
            this.PpriceTb.Name = "PpriceTb";
            this.PpriceTb.Size = new System.Drawing.Size(96, 27);
            this.PpriceTb.TabIndex = 11;
            // 
            // clientNameTb
            // 
            this.clientNameTb.Font = new System.Drawing.Font("Bebas Neue Book", 12F);
            this.clientNameTb.Location = new System.Drawing.Point(15, 138);
            this.clientNameTb.Name = "clientNameTb";
            this.clientNameTb.Size = new System.Drawing.Size(63, 27);
            this.clientNameTb.TabIndex = 9;
            // 
            // PquantityTb
            // 
            this.PquantityTb.Font = new System.Drawing.Font("Bebas Neue Book", 12F);
            this.PquantityTb.Location = new System.Drawing.Point(100, 77);
            this.PquantityTb.Name = "PquantityTb";
            this.PquantityTb.Size = new System.Drawing.Size(80, 27);
            this.PquantityTb.TabIndex = 5;
            // 
            // PtitleTb
            // 
            this.PtitleTb.Enabled = false;
            this.PtitleTb.Font = new System.Drawing.Font("Bebas Neue Book", 12F);
            this.PtitleTb.Location = new System.Drawing.Point(16, 75);
            this.PtitleTb.Name = "PtitleTb";
            this.PtitleTb.Size = new System.Drawing.Size(74, 27);
            this.PtitleTb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 12F);
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Product Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.snameLb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 513);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EliteElectronics.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(43, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "\'s Controll";
            // 
            // snameLb
            // 
            this.snameLb.AutoSize = true;
            this.snameLb.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameLb.Location = new System.Drawing.Point(57, 165);
            this.snameLb.Name = "snameLb";
            this.snameLb.Size = new System.Drawing.Size(76, 32);
            this.snameLb.TabIndex = 28;
            this.snameLb.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Elite Electronics";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(8, 416);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 34);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EliteElectronics.Properties.Resources.right_arrow_symbol;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(859, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductlistDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ProductlistDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button addtobillBtn;
        private System.Windows.Forms.TextBox PpriceTb;
        private System.Windows.Forms.TextBox clientNameTb;
        private System.Windows.Forms.TextBox PquantityTb;
        private System.Windows.Forms.TextBox PtitleTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label snameLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox bidTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}