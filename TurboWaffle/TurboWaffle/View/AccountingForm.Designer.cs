namespace TurboWaffle.View
{
    partial class AccountingForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LstAccounting = new System.Windows.Forms.ListView();
            this.HeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(665, 84);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstAccounting
            // 
            this.LstAccounting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderId,
            this.HeaderCategory,
            this.HeaderDescription,
            this.HeaderAmount});
            this.LstAccounting.FullRowSelect = true;
            this.LstAccounting.Location = new System.Drawing.Point(35, 178);
            this.LstAccounting.Name = "LstAccounting";
            this.LstAccounting.Size = new System.Drawing.Size(730, 211);
            this.LstAccounting.TabIndex = 8;
            this.LstAccounting.UseCompatibleStateImageBehavior = false;
            this.LstAccounting.View = System.Windows.Forms.View.Details;
            // 
            // HeaderId
            // 
            this.HeaderId.Text = "Id";
            // 
            // HeaderCategory
            // 
            this.HeaderCategory.Text = "Category";
            // 
            // HeaderDescription
            // 
            this.HeaderDescription.Text = "Description";
            // 
            // HeaderAmount
            // 
            this.HeaderAmount.Text = "Amount";
            // 
            // CbxCategory
            // 
            this.CbxCategory.DisplayMember = "Description";
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.Location = new System.Drawing.Point(308, 61);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(121, 21);
            this.CbxCategory.TabIndex = 7;
            this.CbxCategory.ValueMember = "Id";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(515, 89);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 6;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(344, 98);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 5;
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstAccounting);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtDescription);
            this.Name = "AccountingForm";
            this.Text = "AccountingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView LstAccounting;
        private System.Windows.Forms.ColumnHeader HeaderId;
        private System.Windows.Forms.ColumnHeader HeaderCategory;
        private System.Windows.Forms.ColumnHeader HeaderDescription;
        private System.Windows.Forms.ColumnHeader HeaderAmount;
        private System.Windows.Forms.ComboBox CbxCategory;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.TextBox TxtDescription;
    }
}