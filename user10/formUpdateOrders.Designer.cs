
namespace user10
{
    partial class formUpdateOrders
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
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Location = new System.Drawing.Point(26, 243);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(99, 41);
            this.buttonInsertOrder.TabIndex = 13;
            this.buttonInsertOrder.Text = "Изменить";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(33, 162);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 20);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Статус";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(33, 97);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(74, 20);
            this.labelProd.TabIndex = 11;
            this.labelProd.Text = "Продукт";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(33, 39);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 20);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Пользователь";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(172, 97);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 28);
            this.comboBoxProduct.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(172, 162);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStatus.TabIndex = 8;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(172, 39);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 28);
            this.comboBoxUser.TabIndex = 7;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(182, 243);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(99, 41);
            this.buttonDeleteOrder.TabIndex = 14;
            this.buttonDeleteOrder.Text = "Удалить";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // formUpdateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 296);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonInsertOrder);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxUser);
            this.Name = "formUpdateOrders";
            this.Text = "Изменение данных заказа";
            this.Load += new System.EventHandler(this.formUpdateOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertOrder;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonDeleteOrder;
    }
}