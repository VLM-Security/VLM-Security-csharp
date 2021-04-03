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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _ICurrencyAuthEvents_OnUpdateEventHandler OnUpdateHandler = new _ICurrencyAuthEvents_OnUpdateEventHandler(AuthObj_OnUpdate);
            AuthObj.OnUpdate += OnUpdateHandler;

            _ICurrencyAuthEvents_OnBulletinEventHandler OnBulletinHandler = new _ICurrencyAuthEvents_OnBulletinEventHandler(AuthObj_OnBulletin);
            AuthObj.OnBulletin += OnBulletinHandler;

            _ICurrencyAuthEvents_OnInvalidEventHandler OnInvalidHandler = new _ICurrencyAuthEvents_OnInvalidEventHandler(AuthObj_OnInvalid);
            AuthObj.OnInvalid += OnInvalidHandler;

            txtValidity.Text = AuthObj.GetValidity();
            txtCode.Text = AuthObj.GetCode();
            txtBulletin.Text = AuthObj.GetBulletin();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            AuthObj.DeductPoint(5);
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            AuthObj.ChangePassword("old-pwd", "new-pwd");
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            byte [] data = new byte[16];
            for(byte i = 0; i < 16; ++i)
            {
                data[i] = AuthObj.GetData(i);
            }
        }

        private void btnProductData_Click(object sender, EventArgs e)
        {
            ushort size = AuthObj.GetProductDataSize();
            byte [] data = new byte[size];
            for (ushort i = 0; i < size; ++i)
            {
                data[i] = AuthObj.GetProductData(i);
            }
        }

        private void btnUnbind_Click(object sender, EventArgs e)
        {
            AuthObj.Unbind();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AuthObj.Update("");
        }

        private void AuthObj_OnUpdate()
        {
            btnUpdate.Enabled = true;
        }

        private void AuthObj_OnBulletin(string text)
        {
            txtBulletin.Text = text;
        }

        private void AuthObj_OnInvalid()
        {
            MessageBox.Show("Invalid,Please contact the developer or agent!", "title", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public CurrencyAuth AuthObj;
    }
}
