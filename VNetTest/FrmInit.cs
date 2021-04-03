using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AllpurAuthenticLib;

namespace CNetTest
{   
    public partial class frmInit : Form
    {
        public frmInit()
        {
            InitializeComponent();
        }

        private void frmInit_Load(object sender, EventArgs e)
        {
            cboMode.Items.Add("Registr-code Mode");
            cboMode.Items.Add("Account Mode");
            cboMode.SelectedIndex = 0;

            frmMain.AuthObj = this.AuthObj;
            this.Text = "VLM--" + AuthObj.GetVersion();
            AuthObj.Initialize("0F3C6EC9-7089-4BB2-B308-508E90A2995E");//product number
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int ret = AuthObj.Auth("0F3C6EC9-7089-4BB2-B308-508E90A2995E");
            if(0 == ret)
            {
                Hide();
                frmMain.ShowDialog();
                Close();
            }
            else
            {
                lblRet.Text = "The Test-card is disabled";
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (0 == cboMode.SelectedIndex)
            {
                ret = AuthObj.Auth(txtAcc.Text);
            }
            else
            {
                ret = AuthObj.UserAuth(txtAcc.Text, txtPwd.Text);
            }

            switch(ret)
            {
            case 0:
                Hide();
                frmMain.ShowDialog();
                Close();
                break;
            case -1:
                lblRet.Text = "The Registr-code is Invalid";
                break;
            case -2:
                lblRet.Text = "The Registr-code is disabled";
                break;
            case -3:
                lblRet.Text = "Bind is over limit";
                break;
            case -4:
                lblRet.Text = "Channels is over limit";
                break;
            case -5:
                lblRet.Text = "Out of date";
                break;
            case -6:
                lblRet.Text = "Insufficient Balance";
                break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Byte  type = 0; //user type 0~15
            Byte  bind = 0; //
            Byte multi = 1; //channel amount, 1~200
            short point = 0; //point, 0~8000

            if(0 == AuthObj.UserRegister(txtName.Text, txtPassword.Text, type, bind, multi, point))
            {
                LblRet2.Text = "Register Succeeded";
            }
            else
            {
                LblRet2.Text = "Register Failed";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            short days  = 0;
            short point = 0;
            if(0 == AuthObj.AddTime(txtCard.Text, txtUser.Text, txtSuper.Text, out days, out point))
            {
                lblRet3.Text = "Renewing Succeeded days:" + days.ToString() + "points:" + point.ToString();
            }
            else
            {
                lblRet3.Text = "Renewing Failed";
            }
        }

        public  FrmMain      frmMain = new FrmMain();
        private CurrencyAuth AuthObj = new CurrencyAuth();
    }
}
