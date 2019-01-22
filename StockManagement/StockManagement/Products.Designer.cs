namespace StockManagement
{
    partial class Products
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
            this.L_ProdCode = new System.Windows.Forms.Label();
            this.L_ProdName = new System.Windows.Forms.Label();
            this.L_Status = new System.Windows.Forms.Label();
            this.TB_ProdCode = new System.Windows.Forms.TextBox();
            this.TB_ProdName = new System.Windows.Forms.TextBox();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.DGV_Prod = new System.Windows.Forms.DataGridView();
            this.ProdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // L_ProdCode
            // 
            this.L_ProdCode.AutoSize = true;
            this.L_ProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ProdCode.Location = new System.Drawing.Point(27, 59);
            this.L_ProdCode.Name = "L_ProdCode";
            this.L_ProdCode.Size = new System.Drawing.Size(111, 20);
            this.L_ProdCode.TabIndex = 0;
            this.L_ProdCode.Text = "Product Code";
            // 
            // L_ProdName
            // 
            this.L_ProdName.AutoSize = true;
            this.L_ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ProdName.Location = new System.Drawing.Point(174, 59);
            this.L_ProdName.Name = "L_ProdName";
            this.L_ProdName.Size = new System.Drawing.Size(116, 20);
            this.L_ProdName.TabIndex = 1;
            this.L_ProdName.Text = "Product Name";
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Status.Location = new System.Drawing.Point(413, 59);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(57, 20);
            this.L_Status.TabIndex = 2;
            this.L_Status.Text = "Status";
            // 
            // TB_ProdCode
            // 
            this.TB_ProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ProdCode.Location = new System.Drawing.Point(27, 88);
            this.TB_ProdCode.Name = "TB_ProdCode";
            this.TB_ProdCode.Size = new System.Drawing.Size(133, 27);
            this.TB_ProdCode.TabIndex = 4;
            // 
            // TB_ProdName
            // 
            this.TB_ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ProdName.Location = new System.Drawing.Point(174, 88);
            this.TB_ProdName.Name = "TB_ProdName";
            this.TB_ProdName.Size = new System.Drawing.Size(224, 27);
            this.TB_ProdName.TabIndex = 3;
            // 
            // CB_Status
            // 
            this.CB_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CB_Status.Location = new System.Drawing.Point(412, 88);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(135, 28);
            this.CB_Status.TabIndex = 5;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Delete.Location = new System.Drawing.Point(585, 88);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(86, 37);
            this.BT_Delete.TabIndex = 6;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.Location = new System.Drawing.Point(688, 88);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(96, 37);
            this.BT_Add.TabIndex = 7;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // DGV_Prod
            // 
            this.DGV_Prod.AllowUserToAddRows = false;
            this.DGV_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdCode,
            this.ProdName,
            this.Status});
            this.DGV_Prod.Location = new System.Drawing.Point(30, 147);
            this.DGV_Prod.Name = "DGV_Prod";
            this.DGV_Prod.RowTemplate.Height = 24;
            this.DGV_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Prod.Size = new System.Drawing.Size(754, 291);
            this.DGV_Prod.TabIndex = 8;
            this.DGV_Prod.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Prod_CellMouseDoubleClick);
            // 
            // ProdCode
            // 
            this.ProdCode.HeaderText = "Product Code";
            this.ProdCode.Name = "ProdCode";
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.Name = "ProdName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 526);
            this.Controls.Add(this.DGV_Prod);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.TB_ProdName);
            this.Controls.Add(this.TB_ProdCode);
            this.Controls.Add(this.L_Status);
            this.Controls.Add(this.L_ProdName);
            this.Controls.Add(this.L_ProdCode);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ProdCode;
        private System.Windows.Forms.Label L_ProdName;
        private System.Windows.Forms.Label L_Status;
        private System.Windows.Forms.TextBox TB_ProdCode;
        private System.Windows.Forms.TextBox TB_ProdName;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.DataGridView DGV_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}