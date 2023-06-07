
namespace user10
{
    partial class formLogin
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
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonVhod = new System.Windows.Forms.Button();
            this.linkLabelVhodBezLog = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(127, 74);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(55, 20);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(127, 153);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(67, 20);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(100, 97);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(100, 26);
            this.textBoxLog.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(100, 176);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 26);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonVhod
            // 
            this.buttonVhod.Location = new System.Drawing.Point(103, 221);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(97, 31);
            this.buttonVhod.TabIndex = 5;
            this.buttonVhod.Text = "Вход";
            this.buttonVhod.UseVisualStyleBackColor = true;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            // 
            // linkLabelVhodBezLog
            // 
            this.linkLabelVhodBezLog.AutoSize = true;
            this.linkLabelVhodBezLog.Location = new System.Drawing.Point(87, 267);
            this.linkLabelVhodBezLog.Name = "linkLabelVhodBezLog";
            this.linkLabelVhodBezLog.Size = new System.Drawing.Size(131, 20);
            this.linkLabelVhodBezLog.TabIndex = 6;
            this.linkLabelVhodBezLog.TabStop = true;
            this.linkLabelVhodBezLog.Text = "Войти как гость";
            this.linkLabelVhodBezLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVhodBezLog_LinkClicked);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 307);
            this.Controls.Add(this.linkLabelVhodBezLog);
            this.Controls.Add(this.buttonVhod);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLog);
            this.MaximumSize = new System.Drawing.Size(330, 363);
            this.MinimumSize = new System.Drawing.Size(330, 363);
            this.Name = "formLogin";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLogin_FormClosed);
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonVhod;
        private System.Windows.Forms.LinkLabel linkLabelVhodBezLog;
    }
}