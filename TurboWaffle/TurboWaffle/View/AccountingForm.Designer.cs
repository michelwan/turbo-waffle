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
            this.HeaderFlowType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.CbxFlowType = new System.Windows.Forms.ComboBox();
            this.LblFlowType = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(713, 52);
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
            this.HeaderFlowType,
            this.HeaderCategory,
            this.HeaderDescription,
            this.HeaderAmount});
            this.LstAccounting.FullRowSelect = true;
            this.LstAccounting.Location = new System.Drawing.Point(12, 81);
            this.LstAccounting.Name = "LstAccounting";
            this.LstAccounting.Size = new System.Drawing.Size(776, 357);
            this.LstAccounting.TabIndex = 8;
            this.LstAccounting.UseCompatibleStateImageBehavior = false;
            this.LstAccounting.View = System.Windows.Forms.View.Details;
            this.LstAccounting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstAccounting_ItemSelectionChanged);
            // 
            // HeaderId
            // 
            this.HeaderId.Text = "Id";
            // 
            // HeaderFlowType
            // 
            this.HeaderFlowType.Text = "Flow type";
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
            this.CbxCategory.Location = new System.Drawing.Point(139, 25);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(121, 21);
            this.CbxCategory.TabIndex = 7;
            this.CbxCategory.ValueMember = "Id";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(688, 26);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 6;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(266, 26);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(416, 20);
            this.TxtDescription.TabIndex = 5;
            // 
            // CbxFlowType
            // 
            this.CbxFlowType.DisplayMember = "Description";
            this.CbxFlowType.FormattingEnabled = true;
            this.CbxFlowType.Location = new System.Drawing.Point(12, 25);
            this.CbxFlowType.Name = "CbxFlowType";
            this.CbxFlowType.Size = new System.Drawing.Size(121, 21);
            this.CbxFlowType.TabIndex = 10;
            this.CbxFlowType.ValueMember = "Id";
            // 
            // LblFlowType
            // 
            this.LblFlowType.AutoSize = true;
            this.LblFlowType.Location = new System.Drawing.Point(12, 9);
            this.LblFlowType.Name = "LblFlowType";
            this.LblFlowType.Size = new System.Drawing.Size(52, 13);
            this.LblFlowType.TabIndex = 11;
            this.LblFlowType.Text = "Flow type";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(136, 9);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(49, 13);
            this.LblCategory.TabIndex = 12;
            this.LblCategory.Text = "Category";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(263, 9);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 13;
            this.LblDescription.Text = "Description";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(685, 9);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(43, 13);
            this.LblAmount.TabIndex = 14;
            this.LblAmount.Text = "Amount";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(12, 52);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(713, 52);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(632, 52);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.LblFlowType);
            this.Controls.Add(this.CbxFlowType);
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
        private System.Windows.Forms.ComboBox CbxFlowType;
        private System.Windows.Forms.ColumnHeader HeaderFlowType;
        private System.Windows.Forms.Label LblFlowType;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
    }
}