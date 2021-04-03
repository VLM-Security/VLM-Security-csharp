namespace CNetTest
{
    partial class FrmMain
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtBulletin = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUnbind = new System.Windows.Forms.Button();
            this.btnProductData = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnUserData = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 151);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 12);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Bulletin";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Check-code";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 12);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Validity";
            // 
            // txtBulletin
            // 
            this.txtBulletin.Location = new System.Drawing.Point(78, 68);
            this.txtBulletin.Multiline = true;
            this.txtBulletin.Name = "txtBulletin";
            this.txtBulletin.Size = new System.Drawing.Size(339, 182);
            this.txtBulletin.TabIndex = 20;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(78, 41);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(339, 21);
            this.txtCode.TabIndex = 19;
            // 
            // txtValidity
            // 
            this.txtValidity.Location = new System.Drawing.Point(78, 14);
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(339, 21);
            this.txtValidity.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(354, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUnbind
            // 
            this.btnUnbind.Location = new System.Drawing.Point(290, 270);
            this.btnUnbind.Name = "btnUnbind";
            this.btnUnbind.Size = new System.Drawing.Size(63, 23);
            this.btnUnbind.TabIndex = 16;
            this.btnUnbind.Text = "Unbind";
            this.btnUnbind.UseVisualStyleBackColor = true;
            this.btnUnbind.Click += new System.EventHandler(this.btnUnbind_Click);
            // 
            // btnProductData
            // 
            this.btnProductData.Location = new System.Drawing.Point(222, 270);
            this.btnProductData.Name = "btnProductData";
            this.btnProductData.Size = new System.Drawing.Size(67, 23);
            this.btnProductData.TabIndex = 15;
            this.btnProductData.Text = "Prod-Data";
            this.btnProductData.UseVisualStyleBackColor = true;
            this.btnProductData.Click += new System.EventHandler(this.btnProductData_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Location = new System.Drawing.Point(90, 270);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(67, 23);
            this.btnChangePwd.TabIndex = 14;
            this.btnChangePwd.Text = "ChangePWD";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnUserData
            // 
            this.btnUserData.Location = new System.Drawing.Point(158, 270);
            this.btnUserData.Name = "btnUserData";
            this.btnUserData.Size = new System.Drawing.Size(63, 23);
            this.btnUserData.TabIndex = 13;
            this.btnUserData.Text = "UserData";
            this.btnUserData.UseVisualStyleBackColor = true;
            this.btnUserData.Click += new System.EventHandler(this.btnUserData_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(10, 270);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(79, 23);
            this.btnAddPoint.TabIndex = 12;
            this.btnAddPoint.Text = "DeductPoint";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 306);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtBulletin);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtValidity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUnbind);
            this.Controls.Add(this.btnProductData);
            this.Controls.Add(this.btnChangePwd);
            this.Controls.Add(this.btnUserData);
            this.Controls.Add(this.btnAddPoint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "VLM";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtBulletin;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.TextBox txtValidity;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnUnbind;
        internal System.Windows.Forms.Button btnProductData;
        internal System.Windows.Forms.Button btnChangePwd;
        internal System.Windows.Forms.Button btnUserData;
        internal System.Windows.Forms.Button btnAddPoint;
    }
}