namespace CountLogic
{
    partial class DetailsFRM
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
            this.ItemsCB = new System.Windows.Forms.ComboBox();
            this.ItemNameLBL = new System.Windows.Forms.Label();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.CostPerCaseTB = new System.Windows.Forms.TextBox();
            this.QTYPerCaseTB = new System.Windows.Forms.TextBox();
            this.CostPerItemTB = new System.Windows.Forms.TextBox();
            this.InventoryLBL = new System.Windows.Forms.Label();
            this.CostPerCaseLBL = new System.Windows.Forms.Label();
            this.QTYPerCaseLBL = new System.Windows.Forms.Label();
            this.CostPerItemLBL = new System.Windows.Forms.Label();
            this.SellingPriceLBL = new System.Windows.Forms.Label();
            this.ProfitPerCaseLBL = new System.Windows.Forms.Label();
            this.ProfitPerItemLBL = new System.Windows.Forms.Label();
            this.SellingPriceTB = new System.Windows.Forms.TextBox();
            this.ProfitPerCaseTB = new System.Windows.Forms.TextBox();
            this.ProfitPerItemTB = new System.Windows.Forms.TextBox();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemsCB
            // 
            this.ItemsCB.BackColor = System.Drawing.Color.White;
            this.ItemsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsCB.ForeColor = System.Drawing.Color.Black;
            this.ItemsCB.FormattingEnabled = true;
            this.ItemsCB.Location = new System.Drawing.Point(351, 26);
            this.ItemsCB.Name = "ItemsCB";
            this.ItemsCB.Size = new System.Drawing.Size(363, 47);
            this.ItemsCB.TabIndex = 1;
            this.ItemsCB.SelectedIndexChanged += new System.EventHandler(this.ItemsCB_SelectedIndexChanged);
            // 
            // ItemNameLBL
            // 
            this.ItemNameLBL.AutoSize = true;
            this.ItemNameLBL.Location = new System.Drawing.Point(86, 29);
            this.ItemNameLBL.Name = "ItemNameLBL";
            this.ItemNameLBL.Size = new System.Drawing.Size(231, 39);
            this.ItemNameLBL.TabIndex = 0;
            this.ItemNameLBL.Text = "Pick an &Item:";
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(351, 103);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.ReadOnly = true;
            this.InventoryTB.Size = new System.Drawing.Size(136, 46);
            this.InventoryTB.TabIndex = 3;
            // 
            // CostPerCaseTB
            // 
            this.CostPerCaseTB.Location = new System.Drawing.Point(351, 181);
            this.CostPerCaseTB.Name = "CostPerCaseTB";
            this.CostPerCaseTB.ReadOnly = true;
            this.CostPerCaseTB.Size = new System.Drawing.Size(136, 46);
            this.CostPerCaseTB.TabIndex = 5;
            // 
            // QTYPerCaseTB
            // 
            this.QTYPerCaseTB.Location = new System.Drawing.Point(351, 268);
            this.QTYPerCaseTB.Name = "QTYPerCaseTB";
            this.QTYPerCaseTB.ReadOnly = true;
            this.QTYPerCaseTB.Size = new System.Drawing.Size(136, 46);
            this.QTYPerCaseTB.TabIndex = 7;
            // 
            // CostPerItemTB
            // 
            this.CostPerItemTB.Location = new System.Drawing.Point(351, 355);
            this.CostPerItemTB.Name = "CostPerItemTB";
            this.CostPerItemTB.ReadOnly = true;
            this.CostPerItemTB.Size = new System.Drawing.Size(136, 46);
            this.CostPerItemTB.TabIndex = 9;
            // 
            // InventoryLBL
            // 
            this.InventoryLBL.AutoSize = true;
            this.InventoryLBL.Location = new System.Drawing.Point(12, 110);
            this.InventoryLBL.Name = "InventoryLBL";
            this.InventoryLBL.Size = new System.Drawing.Size(305, 39);
            this.InventoryLBL.TabIndex = 2;
            this.InventoryLBL.Text = "Current In&ventory";
            // 
            // CostPerCaseLBL
            // 
            this.CostPerCaseLBL.AutoSize = true;
            this.CostPerCaseLBL.Location = new System.Drawing.Point(83, 188);
            this.CostPerCaseLBL.Name = "CostPerCaseLBL";
            this.CostPerCaseLBL.Size = new System.Drawing.Size(234, 39);
            this.CostPerCaseLBL.TabIndex = 4;
            this.CostPerCaseLBL.Text = "C&ost Per Case";
            // 
            // QTYPerCaseLBL
            // 
            this.QTYPerCaseLBL.AutoSize = true;
            this.QTYPerCaseLBL.Location = new System.Drawing.Point(15, 275);
            this.QTYPerCaseLBL.Name = "QTYPerCaseLBL";
            this.QTYPerCaseLBL.Size = new System.Drawing.Size(302, 39);
            this.QTYPerCaseLBL.TabIndex = 6;
            this.QTYPerCaseLBL.Text = "&Quantity Per Case";
            this.QTYPerCaseLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CostPerItemLBL
            // 
            this.CostPerItemLBL.AutoSize = true;
            this.CostPerItemLBL.Location = new System.Drawing.Point(80, 362);
            this.CostPerItemLBL.Name = "CostPerItemLBL";
            this.CostPerItemLBL.Size = new System.Drawing.Size(237, 39);
            this.CostPerItemLBL.TabIndex = 8;
            this.CostPerItemLBL.Text = "Cost &Per Item";
            this.CostPerItemLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SellingPriceLBL
            // 
            this.SellingPriceLBL.AutoSize = true;
            this.SellingPriceLBL.Location = new System.Drawing.Point(101, 623);
            this.SellingPriceLBL.Name = "SellingPriceLBL";
            this.SellingPriceLBL.Size = new System.Drawing.Size(216, 39);
            this.SellingPriceLBL.TabIndex = 14;
            this.SellingPriceLBL.Text = "&Selling Price";
            this.SellingPriceLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfitPerCaseLBL
            // 
            this.ProfitPerCaseLBL.AutoSize = true;
            this.ProfitPerCaseLBL.Location = new System.Drawing.Point(63, 536);
            this.ProfitPerCaseLBL.Name = "ProfitPerCaseLBL";
            this.ProfitPerCaseLBL.Size = new System.Drawing.Size(254, 39);
            this.ProfitPerCaseLBL.TabIndex = 12;
            this.ProfitPerCaseLBL.Text = "Profit Per C&ase";
            this.ProfitPerCaseLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfitPerItemLBL
            // 
            this.ProfitPerItemLBL.AutoSize = true;
            this.ProfitPerItemLBL.Location = new System.Drawing.Point(60, 449);
            this.ProfitPerItemLBL.Name = "ProfitPerItemLBL";
            this.ProfitPerItemLBL.Size = new System.Drawing.Size(257, 39);
            this.ProfitPerItemLBL.TabIndex = 10;
            this.ProfitPerItemLBL.Text = "P&rofit Per Item";
            // 
            // SellingPriceTB
            // 
            this.SellingPriceTB.Location = new System.Drawing.Point(351, 616);
            this.SellingPriceTB.Name = "SellingPriceTB";
            this.SellingPriceTB.ReadOnly = true;
            this.SellingPriceTB.Size = new System.Drawing.Size(136, 46);
            this.SellingPriceTB.TabIndex = 15;
            // 
            // ProfitPerCaseTB
            // 
            this.ProfitPerCaseTB.Location = new System.Drawing.Point(351, 529);
            this.ProfitPerCaseTB.Name = "ProfitPerCaseTB";
            this.ProfitPerCaseTB.ReadOnly = true;
            this.ProfitPerCaseTB.Size = new System.Drawing.Size(136, 46);
            this.ProfitPerCaseTB.TabIndex = 13;
            // 
            // ProfitPerItemTB
            // 
            this.ProfitPerItemTB.Location = new System.Drawing.Point(351, 442);
            this.ProfitPerItemTB.Name = "ProfitPerItemTB";
            this.ProfitPerItemTB.ReadOnly = true;
            this.ProfitPerItemTB.Size = new System.Drawing.Size(136, 46);
            this.ProfitPerItemTB.TabIndex = 11;
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.Navy;
            this.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(508, 616);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(206, 46);
            this.CloseBTN.TabIndex = 16;
            this.CloseBTN.Text = "C&lose";
            this.CloseBTN.UseVisualStyleBackColor = false;
           // 
            // DetailsFRM
            // 
            this.AcceptButton = this.CloseBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(728, 682);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.SellingPriceLBL);
            this.Controls.Add(this.ProfitPerCaseLBL);
            this.Controls.Add(this.ProfitPerItemLBL);
            this.Controls.Add(this.SellingPriceTB);
            this.Controls.Add(this.ProfitPerCaseTB);
            this.Controls.Add(this.ProfitPerItemTB);
            this.Controls.Add(this.CostPerItemLBL);
            this.Controls.Add(this.QTYPerCaseLBL);
            this.Controls.Add(this.CostPerCaseLBL);
            this.Controls.Add(this.InventoryLBL);
            this.Controls.Add(this.CostPerItemTB);
            this.Controls.Add(this.QTYPerCaseTB);
            this.Controls.Add(this.CostPerCaseTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.ItemNameLBL);
            this.Controls.Add(this.ItemsCB);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "DetailsFRM";
            this.Text = "CountLogig - Item Details";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemsCB;
        private System.Windows.Forms.Label ItemNameLBL;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox CostPerCaseTB;
        private System.Windows.Forms.TextBox QTYPerCaseTB;
        private System.Windows.Forms.TextBox CostPerItemTB;
        private System.Windows.Forms.Label InventoryLBL;
        private System.Windows.Forms.Label CostPerCaseLBL;
        private System.Windows.Forms.Label QTYPerCaseLBL;
        private System.Windows.Forms.Label CostPerItemLBL;
        private System.Windows.Forms.Label SellingPriceLBL;
        private System.Windows.Forms.Label ProfitPerCaseLBL;
        private System.Windows.Forms.Label ProfitPerItemLBL;
        private System.Windows.Forms.TextBox SellingPriceTB;
        private System.Windows.Forms.TextBox ProfitPerCaseTB;
        private System.Windows.Forms.TextBox ProfitPerItemTB;
        private System.Windows.Forms.Button CloseBTN;
    }
}