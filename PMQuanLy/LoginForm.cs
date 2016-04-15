using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMQuanLy.Model;

namespace PMQuanLy
{
    public partial class LoginForm : Form
    {
        MemberModel mMember;
        bool login_flg = false;
        public LoginForm()
        {
            InitializeComponent();
            mMember = new MemberModel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login_flg = mMember.isLoginSuccess(txt_username.Text.ToString(), txt_password.Text.ToString());
            if (login_flg == true)
            {
                MainForm fMain = new MainForm();
                this.Hide();
                fMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("username or Password incorrect!!!");
            }
        }
    }
}
