namespace SignUpDemo
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.register_license = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.login_label);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(214, 443);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_label.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(36, 413);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(138, 21);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Go to Sign In Page";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button2);
            this.panelRight.Controls.Add(this.bunifuCheckbox1);
            this.panelRight.Controls.Add(this.register_license);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.register_email);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.register_password);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.register_username);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(214, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(251, 443);
            this.panelRight.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button2.Location = new System.Drawing.Point(61, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Register Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(19, 365);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 3;
            // 
            // register_license
            // 
            this.register_license.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_license.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.register_license.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_license.HintForeColor = System.Drawing.Color.Empty;
            this.register_license.HintText = "AraCore-License-000";
            this.register_license.isPassword = false;
            this.register_license.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_license.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_license.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_license.LineThickness = 4;
            this.register_license.Location = new System.Drawing.Point(19, 318);
            this.register_license.Margin = new System.Windows.Forms.Padding(4);
            this.register_license.Name = "register_license";
            this.register_license.Size = new System.Drawing.Size(194, 31);
            this.register_license.TabIndex = 1;
            this.register_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label7.Location = new System.Drawing.Point(45, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "I Agree Terms and Conditions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label6.Location = new System.Drawing.Point(15, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "License";
            // 
            // register_email
            // 
            this.register_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.register_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_email.HintForeColor = System.Drawing.Color.Empty;
            this.register_email.HintText = "someone@example.com";
            this.register_email.isPassword = false;
            this.register_email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_email.LineThickness = 4;
            this.register_email.Location = new System.Drawing.Point(19, 247);
            this.register_email.Margin = new System.Windows.Forms.Padding(4);
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(194, 31);
            this.register_email.TabIndex = 1;
            this.register_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label5.Location = new System.Drawing.Point(15, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // register_password
            // 
            this.register_password.BackColor = System.Drawing.SystemColors.Control;
            this.register_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.register_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_password.HintForeColor = System.Drawing.Color.Empty;
            this.register_password.HintText = "Password";
            this.register_password.isPassword = true;
            this.register_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_password.LineThickness = 4;
            this.register_password.Location = new System.Drawing.Point(19, 176);
            this.register_password.Margin = new System.Windows.Forms.Padding(4);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(194, 31);
            this.register_password.TabIndex = 1;
            this.register_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // register_username
            // 
            this.register_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.register_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_username.HintForeColor = System.Drawing.Color.Empty;
            this.register_username.HintText = "AraCore";
            this.register_username.isPassword = false;
            this.register_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.register_username.LineThickness = 4;
            this.register_username.Location = new System.Drawing.Point(19, 105);
            this.register_username.Margin = new System.Windows.Forms.Padding(4);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(194, 31);
            this.register_username.TabIndex = 1;
            this.register_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label8.Location = new System.Drawing.Point(214, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 443);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraCore-Register";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox register_license;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox register_email;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

