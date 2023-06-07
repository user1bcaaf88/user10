
namespace user10
{
    partial class formUpdateProduct
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
            this.comboBoxManuf = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonUpdateProd = new System.Windows.Forms.Button();
            this.labelManuf = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDeleteProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxManuf
            // 
            this.comboBoxManuf.FormattingEnabled = true;
            this.comboBoxManuf.Location = new System.Drawing.Point(205, 213);
            this.comboBoxManuf.Name = "comboBoxManuf";
            this.comboBoxManuf.Size = new System.Drawing.Size(131, 28);
            this.comboBoxManuf.TabIndex = 17;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(205, 160);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(131, 26);
            this.textBoxCost.TabIndex = 16;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(205, 106);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(131, 26);
            this.textBoxDesc.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(205, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 26);
            this.textBoxName.TabIndex = 14;
            // 
            // buttonUpdateProd
            // 
            this.buttonUpdateProd.Location = new System.Drawing.Point(202, 276);
            this.buttonUpdateProd.Name = "buttonUpdateProd";
            this.buttonUpdateProd.Size = new System.Drawing.Size(134, 26);
            this.buttonUpdateProd.TabIndex = 13;
            this.buttonUpdateProd.Text = "Изменить";
            this.buttonUpdateProd.UseVisualStyleBackColor = true;
            this.buttonUpdateProd.Click += new System.EventHandler(this.buttonUpdateProd_Click);
            // 
            // labelManuf
            // 
            this.labelManuf.AutoSize = true;
            this.labelManuf.Location = new System.Drawing.Point(71, 215);
            this.labelManuf.Name = "labelManuf";
            this.labelManuf.Size = new System.Drawing.Size(89, 20);
            this.labelManuf.TabIndex = 12;
            this.labelManuf.Text = "Категория";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(71, 160);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(48, 20);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Цена";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(71, 106);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(83, 20);
            this.labelDesc.TabIndex = 10;
            this.labelDesc.Text = "Описание";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(71, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Название";
            // 
            // buttonDeleteProd
            // 
            this.buttonDeleteProd.Location = new System.Drawing.Point(384, 276);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(134, 26);
            this.buttonDeleteProd.TabIndex = 18;
            this.buttonDeleteProd.Text = "Удалить";
            this.buttonDeleteProd.UseVisualStyleBackColor = true;
            this.buttonDeleteProd.Click += new System.EventHandler(this.buttonDeleteProd_Click);
            // 
            // formUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 314);
            this.Controls.Add(this.buttonDeleteProd);
            this.Controls.Add(this.comboBoxManuf);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonUpdateProd);
            this.Controls.Add(this.labelManuf);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(581, 370);
            this.MinimumSize = new System.Drawing.Size(581, 370);
            this.Name = "formUpdateProduct";
            this.Text = "Изменение данных о продуктах ";
            this.Load += new System.EventHandler(this.formUpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxManuf;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdateProd;
        private System.Windows.Forms.Label labelManuf;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDeleteProd;
    }
}