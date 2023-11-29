namespace BankingApp
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.transToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem1,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomersToolStripMenuItem});
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.newAccountToolStripMenuItem.Text = "Account";
            // 
            // newAccountToolStripMenuItem1
            // 
            this.newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            this.newAccountToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.newAccountToolStripMenuItem1.Text = "New Account";
            this.newAccountToolStripMenuItem1.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.updateSearchAccountToolStripMenuItem.Text = "Update/Delete Account";
            this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferFormToolStripMenuItem,
            this.allTransactionsToolStripMenuItem});
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transToolStripMenuItem.Text = "Transactions";
            // 
            // transferFormToolStripMenuItem
            // 
            this.transferFormToolStripMenuItem.Name = "transferFormToolStripMenuItem";
            this.transferFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transferFormToolStripMenuItem.Text = "TransferForm";
            this.transferFormToolStripMenuItem.Click += new System.EventHandler(this.transferFormToolStripMenuItem_Click);
            // 
            // allTransactionsToolStripMenuItem
            // 
            this.allTransactionsToolStripMenuItem.Name = "allTransactionsToolStripMenuItem";
            this.allTransactionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allTransactionsToolStripMenuItem.Text = "All Transactions";
            this.allTransactionsToolStripMenuItem.Click += new System.EventHandler(this.allTransactionsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 717);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}