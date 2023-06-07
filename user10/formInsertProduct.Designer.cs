
namespace user10
{
    partial class formInsertProduct
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelManuf = new System.Windows.Forms.Label();
            this.buttonInsertProd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.comboBoxManuf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(53, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(53, 124);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(83, 20);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Описание";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(53, 178);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(48, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Цена";
            // 
            // labelManuf
            // 
            this.labelManuf.AutoSize = true;
            this.labelManuf.Location = new System.Drawing.Point(53, 233);
            this.labelManuf.Name = "labelManuf";
            this.labelManuf.Size = new System.Drawing.Size(89, 20);
            this.labelManuf.TabIndex = 3;
            this.labelManuf.Text = "Категория";
            // 
            // buttonInsertProd
            // 
            this.buttonInsertProd.Location = new System.Drawing.Point(366, 296);
            this.buttonInsertProd.Name = "buttonInsertProd";
            this.buttonInsertProd.Size = new System.Drawing.Size(134, 26);
            this.buttonInsertProd.TabIndex = 4;
            this.buttonInsertProd.Text = "Добавить";
            this.buttonInsertProd.UseVisualStyleBackColor = true;
            this.buttonInsertProd.Click += new System.EventHandler(this.buttonInsertProd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(187, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(187, 124);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(131, 26);
            this.textBoxDesc.TabIndex = 6;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(187, 178);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(131, 26);
            this.textBoxCost.TabIndex = 7;
            // 
            // comboBoxManuf
            // 
            this.comboBoxManuf.FormattingEnabled = true;
            this.comboBoxManuf.Location = new System.Drawing.Point(187, 231);
            this.comboBoxManuf.Name = "comboBoxManuf";
            this.comboBoxManuf.Size = new System.Drawing.Size(127, 28);
            this.comboBoxManuf.TabIndex = 8;
            // 
            // formInsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 334);
            this.Controls.Add(this.comboBoxManuf);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonInsertProd);
            this.Controls.Add(this.labelManuf);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(534, 390);
            this.MinimumSize = new System.Drawing.Size(534, 390);
            this.Name = "formInsertProduct";
            this.Text = "Добавление продуктов";
            this.Load += new System.EventHandler(this.formInsertProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelManuf;
        private System.Windows.Forms.Button buttonInsertProd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.ComboBox comboBoxManuf;
    }
}