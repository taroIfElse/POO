namespace VISTA
{
    partial class Welcome
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.brnRegister = new System.Windows.Forms.Button();
            this.WelcomeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(48, 91);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // brnRegister
            // 
            this.brnRegister.Location = new System.Drawing.Point(48, 146);
            this.brnRegister.Name = "brnRegister";
            this.brnRegister.Size = new System.Drawing.Size(75, 25);
            this.brnRegister.TabIndex = 1;
            this.brnRegister.Text = "Register";
            this.brnRegister.UseVisualStyleBackColor = true;
            this.brnRegister.Click += new System.EventHandler(this.brnRegister_Click);
            // 
            // WelcomeTitle
            // 
            this.WelcomeTitle.AutoSize = true;
            this.WelcomeTitle.Location = new System.Drawing.Point(45, 45);
            this.WelcomeTitle.Name = "WelcomeTitle";
            this.WelcomeTitle.Size = new System.Drawing.Size(55, 13);
            this.WelcomeTitle.TabIndex = 2;
            this.WelcomeTitle.Text = "Great App";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 211);
            this.Controls.Add(this.WelcomeTitle);
            this.Controls.Add(this.brnRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button brnRegister;
        private System.Windows.Forms.Label WelcomeTitle;
    }
}