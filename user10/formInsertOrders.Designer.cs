
namespace user10
{
    partial class formInsertOrders
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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(170, 68);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 28);
            this.comboBoxUser.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(170, 191);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(170, 126);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 28);
            this.comboBoxProduct.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(31, 68);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 20);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Пользователь";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(31, 126);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(74, 20);
            this.labelProd.TabIndex = 4;
            this.labelProd.Text = "Продукт";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(31, 191);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Статус";
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Location = new System.Drawing.Point(92, 249);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(166, 41);
            this.buttonInsertOrder.TabIndex = 6;
            this.buttonInsertOrder.Text = "Добавить";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // formInsertOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 362);
            this.Controls.Add(this.buttonInsertOrder);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxUser);
            this.Name = "formInsertOrders";
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.formInsertOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonInsertOrder;
    }
}