namespace CaveGame
{
    partial class Login
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
            this.btlogin = new System.Windows.Forms.Button();
            this.btregister = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lberror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Black;
            this.btlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogin.Location = new System.Drawing.Point(128, 192);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.Color.Black;
            this.btregister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btregister.Location = new System.Drawing.Point(35, 192);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(75, 23);
            this.btregister.TabIndex = 1;
            this.btregister.Text = "register";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(35, 100);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(168, 20);
            this.tbusername.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(35, 135);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(168, 20);
            this.tbpassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 88);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lberror.Location = new System.Drawing.Point(93, 243);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(0, 13);
            this.lberror.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(240, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.btlogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lberror;
    }
}