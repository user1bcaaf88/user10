
namespace user10
{
    partial class formMenu
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.panelOrdersBig = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlMenu.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageProduct);
            this.tabControlMenu.Controls.Add(this.tabPageOrders);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(800, 450);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.buttonBuy);
            this.tabPageProduct.Controls.Add(this.buttonInsertProduct);
            this.tabPageProduct.Controls.Add(this.buttonBack);
            this.tabPageProduct.Controls.Add(this.panelProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(792, 417);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Продукты";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.buttonInsertOrder);
            this.tabPageOrders.Controls.Add(this.buttonBack2);
            this.tabPageOrders.Controls.Add(this.panelOrdersBig);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(792, 417);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(615, 364);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(110, 36);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Корзина";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.Location = new System.Drawing.Point(341, 364);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(110, 36);
            this.buttonInsertProduct.TabIndex = 6;
            this.buttonInsertProduct.Text = "Добавить";
            this.buttonInsertProduct.UseVisualStyleBackColor = true;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(41, 364);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 36);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduct.Location = new System.Drawing.Point(23, 16);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(746, 304);
            this.panelProduct.TabIndex = 4;
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Location = new System.Drawing.Point(341, 364);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(110, 36);
            this.buttonInsertOrder.TabIndex = 10;
            this.buttonInsertOrder.Text = "Добавить";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Location = new System.Drawing.Point(41, 364);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(110, 36);
            this.buttonBack2.TabIndex = 9;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // panelOrdersBig
            // 
            this.panelOrdersBig.AutoScroll = true;
            this.panelOrdersBig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrdersBig.Location = new System.Drawing.Point(23, 16);
            this.panelOrdersBig.Name = "panelOrdersBig";
            this.panelOrdersBig.Size = new System.Drawing.Size(722, 309);
            this.panelOrdersBig.TabIndex = 8;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu);
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "formMenu";
            this.Text = "formMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMenu_FormClosed);
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonInsertProduct;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FlowLayoutPanel panelProduct;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.Button buttonInsertOrder;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.FlowLayoutPanel panelOrdersBig;
    }
}