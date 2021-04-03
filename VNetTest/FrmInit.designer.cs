namespace CNetTest
{
    partial class frmInit
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.lblRet = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.LblRet2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tabPay = new System.Windows.Forms.TabPage();
            this.txtSuper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblRet3 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabAuth);
            this.TabControl.Controls.Add(this.tabRegister);
            this.TabControl.Controls.Add(this.tabPay);
            this.TabControl.Location = new System.Drawing.Point(13, 16);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(366, 198);
            this.TabControl.TabIndex = 1;
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.lblRet);
            this.tabAuth.Controls.Add(this.btnTest);
            this.tabAuth.Controls.Add(this.lblMode);
            this.tabAuth.Controls.Add(this.txtPwd);
            this.tabAuth.Controls.Add(this.lblPwd);
            this.tabAuth.Controls.Add(this.txtAcc);
            this.tabAuth.Controls.Add(this.lblAcc);
            this.tabAuth.Controls.Add(this.btnExit);
            this.tabAuth.Controls.Add(this.btnAuth);
            this.tabAuth.Controls.Add(this.cboMode);
            this.tabAuth.Location = new System.Drawing.Point(4, 22);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuth.Size = new System.Drawing.Size(358, 172);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Login";
            this.tabAuth.UseVisualStyleBackColor = true;
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = true;
            this.lblRet.Location = new System.Drawing.Point(8, 154);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(0, 12);
            this.lblRet.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(75, 115);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 30);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Trial";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(24, 24);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(29, 12);
            this.lblMode.TabIndex = 7;
            this.lblMode.Text = "Mode";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(75, 78);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(281, 21);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Visible = false;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(16, 81);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "Password";
            this.lblPwd.Visible = false;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(75, 49);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(281, 21);
            this.txtAcc.TabIndex = 4;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(-2, 52);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(77, 12);
            this.lblAcc.TabIndex = 3;
            this.lblAcc.Text = "Registr-code";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(161, 115);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 30);
            this.btnAuth.TabIndex = 1;
            this.btnAuth.Text = "Login";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // cboMode
            // 
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Location = new System.Drawing.Point(75, 21);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(281, 20);
            this.cboMode.TabIndex = 0;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.LblRet2);
            this.tabRegister.Controls.Add(this.txtPassword);
            this.tabRegister.Controls.Add(this.Label1);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.Label2);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(358, 172);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(118, 127);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 28);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LblRet2
            // 
            this.LblRet2.AutoSize = true;
            this.LblRet2.Location = new System.Drawing.Point(16, 89);
            this.LblRet2.Name = "LblRet2";
            this.LblRet2.Size = new System.Drawing.Size(0, 12);
            this.LblRet2.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 21);
            this.txtPassword.TabIndex = 10;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 12);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 21);
            this.txtName.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 12);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Account";
            // 
            // tabPay
            // 
            this.tabPay.Controls.Add(this.txtSuper);
            this.tabPay.Controls.Add(this.label3);
            this.tabPay.Controls.Add(this.txtCard);
            this.tabPay.Controls.Add(this.Label4);
            this.tabPay.Controls.Add(this.txtUser);
            this.tabPay.Controls.Add(this.Label5);
            this.tabPay.Controls.Add(this.btnPay);
            this.tabPay.Controls.Add(this.lblRet3);
            this.tabPay.Location = new System.Drawing.Point(4, 22);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPay.Size = new System.Drawing.Size(358, 172);
            this.tabPay.TabIndex = 2;
            this.tabPay.Text = "Recharge";
            this.tabPay.UseVisualStyleBackColor = true;
            // 
            // txtSuper
            // 
            this.txtSuper.Location = new System.Drawing.Point(84, 79);
            this.txtSuper.Name = "txtSuper";
            this.txtSuper.Size = new System.Drawing.Size(260, 21);
            this.txtSuper.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Promoter";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(84, 50);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(260, 21);
            this.txtCard.TabIndex = 17;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(-1, 53);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 12);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Recharge-card";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(84, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(260, 21);
            this.txtUser.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 12);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Account";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(118, 127);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(117, 28);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Activate";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblRet3
            // 
            this.lblRet3.AutoSize = true;
            this.lblRet3.Location = new System.Drawing.Point(16, 110);
            this.lblRet3.Name = "lblRet3";
            this.lblRet3.Size = new System.Drawing.Size(0, 12);
            this.lblRet3.TabIndex = 12;
            // 
            // frmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 224);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInit";
            this.Text = "VLM";
            this.Load += new System.EventHandler(this.frmInit_Load);
            this.TabControl.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabPay.ResumeLayout(false);
            this.tabPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl;
        internal System.Windows.Forms.TabPage tabAuth;
        internal System.Windows.Forms.Label lblRet;
        internal System.Windows.Forms.Button btnTest;
        internal System.Windows.Forms.Label lblMode;
        internal System.Windows.Forms.TextBox txtPwd;
        internal System.Windows.Forms.Label lblPwd;
        internal System.Windows.Forms.TextBox txtAcc;
        internal System.Windows.Forms.Label lblAcc;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnAuth;
        internal System.Windows.Forms.ComboBox cboMode;
        internal System.Windows.Forms.TabPage tabRegister;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.Label LblRet2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TabPage tabPay;
        internal System.Windows.Forms.TextBox txtCard;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnPay;
        internal System.Windows.Forms.Label lblRet3;
        internal System.Windows.Forms.TextBox txtSuper;
        internal System.Windows.Forms.Label label3;
    }
}

