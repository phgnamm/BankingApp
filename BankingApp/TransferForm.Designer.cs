namespace BankingApp
{
    partial class TransferForm
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
            this.datelbn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfromacc = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtdestina = new System.Windows.Forms.TextBox();
            this.txttrnsfer = new System.Windows.Forms.TextBox();
            this.btndetail = new System.Windows.Forms.Button();
            this.btntransfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamount2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btndetail1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datelbn
            // 
            this.datelbn.AutoSize = true;
            this.datelbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbn.ForeColor = System.Drawing.Color.Black;
            this.datelbn.Location = new System.Drawing.Point(48, 16);
            this.datelbn.Name = "datelbn";
            this.datelbn.Size = new System.Drawing.Size(212, 25);
            this.datelbn.TabIndex = 0;
            this.datelbn.Text = "BANKING TRANSFER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(174, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount to be transferred";
            // 
            // txtfromacc
            // 
            this.txtfromacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromacc.Location = new System.Drawing.Point(308, 123);
            this.txtfromacc.Name = "txtfromacc";
            this.txtfromacc.Size = new System.Drawing.Size(219, 27);
            this.txtfromacc.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(308, 170);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(219, 27);
            this.txtname.TabIndex = 7;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(308, 229);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(219, 27);
            this.txtamount.TabIndex = 8;
            // 
            // txtdestina
            // 
            this.txtdestina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestina.Location = new System.Drawing.Point(308, 298);
            this.txtdestina.Name = "txtdestina";
            this.txtdestina.Size = new System.Drawing.Size(219, 27);
            this.txtdestina.TabIndex = 9;
            // 
            // txttrnsfer
            // 
            this.txttrnsfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrnsfer.Location = new System.Drawing.Point(308, 517);
            this.txttrnsfer.Name = "txttrnsfer";
            this.txttrnsfer.Size = new System.Drawing.Size(219, 27);
            this.txttrnsfer.TabIndex = 10;
            // 
            // btndetail
            // 
            this.btndetail.Location = new System.Drawing.Point(12, 164);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(94, 33);
            this.btndetail.TabIndex = 11;
            this.btndetail.Text = "Detail";
            this.btndetail.UseVisualStyleBackColor = true;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // btntransfer
            // 
            this.btntransfer.Location = new System.Drawing.Point(258, 640);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(151, 48);
            this.btntransfer.TabIndex = 12;
            this.btntransfer.Text = "Transfer";
            this.btntransfer.UseVisualStyleBackColor = true;
            this.btntransfer.Click += new System.EventHandler(this.btntransfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(195, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "BANKING TRANSFER";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(1220, 74);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(105, 34);
            this.btnsearch.TabIndex = 18;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(620, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 460);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(969, 86);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(208, 22);
            this.txtsearch.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search By ID";
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(1362, 74);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(100, 34);
            this.btnshowall.TabIndex = 19;
            this.btnshowall.Text = "Show All ";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // txtname1
            // 
            this.txtname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname1.Location = new System.Drawing.Point(308, 363);
            this.txtname1.Name = "txtname1";
            this.txtname1.ReadOnly = true;
            this.txtname1.Size = new System.Drawing.Size(219, 27);
            this.txtname1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name";
            // 
            // txtamount2
            // 
            this.txtamount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount2.Location = new System.Drawing.Point(308, 423);
            this.txtamount2.Name = "txtamount2";
            this.txtamount2.ReadOnly = true;
            this.txtamount2.Size = new System.Drawing.Size(219, 27);
            this.txtamount2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Current Amount";
            // 
            // btndetail1
            // 
            this.btndetail1.Location = new System.Drawing.Point(12, 353);
            this.btndetail1.Name = "btndetail1";
            this.btndetail1.Size = new System.Drawing.Size(94, 33);
            this.btndetail1.TabIndex = 24;
            this.btndetail1.Text = "Detail";
            this.btndetail1.UseVisualStyleBackColor = true;
            this.btndetail1.Click += new System.EventHandler(this.btndetail1_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 762);
            this.Controls.Add(this.btndetail1);
            this.Controls.Add(this.txtamount2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtname1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntransfer);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.txttrnsfer);
            this.Controls.Add(this.txtdestina);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtfromacc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbn);
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransferForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfromacc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtdestina;
        private System.Windows.Forms.TextBox txttrnsfer;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamount2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btndetail1;
    }
}