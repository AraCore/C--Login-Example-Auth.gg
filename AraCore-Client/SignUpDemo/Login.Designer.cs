namespace SignUpDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.login_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.login_label);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(214, 343);
            this.panelLeft.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_label.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(40, 313);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(147, 21);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Go to Register Page";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.SystemColors.Control;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_password.HintForeColor = System.Drawing.Color.Empty;
            this.login_password.HintText = "Password";
            this.login_password.isPassword = true;
            this.login_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_password.LineThickness = 4;
            this.login_password.Location = new System.Drawing.Point(239, 184);
            this.login_password.Margin = new System.Windows.Forms.Padding(4);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(194, 31);
            this.login_password.TabIndex = 4;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(235, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // login_username
            // 
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_username.HintForeColor = System.Drawing.Color.Empty;
            this.login_username.HintText = "AraCore";
            this.login_username.isPassword = false;
            this.login_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.login_username.LineThickness = 4;
            this.login_username.Location = new System.Drawing.Point(239, 113);
            this.login_username.Margin = new System.Windows.Forms.Padding(4);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(194, 31);
            this.login_username.TabIndex = 5;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(240, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(234, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label8.Location = new System.Drawing.Point(428, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.AutoSize = true;
            this.loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.loginbtn.Location = new System.Drawing.Point(269, 286);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(137, 31);
            this.loginbtn.TabIndex = 10;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(269, 250);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label7.Location = new System.Drawing.Point(295, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Remember me";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 343);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraCore-Login";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login_password;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loginbtn;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label login_label;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}