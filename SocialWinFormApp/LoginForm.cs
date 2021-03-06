﻿using BusinessLogic.Interface;
using SocialWinFormApp.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace SocialWinFormApp
{
    public partial class LoginForm : Form
    {
        private readonly IAuthManager _authManager;
        private readonly IUserManager _userManager;
        private readonly IAppUser _user;
        public LoginForm(IAuthManager authManager,IUserManager userManager, IAppUser user)
        {
            this._authManager = authManager;
            this._user = user;
            this._userManager = userManager;
            InitializeComponent();

        }
        private void DoLogin()
        {
            if(this._authManager.Login(Login.Text,Password.Text))
            {
                this._user.Login = Login.Text;
                this._user.UserId = this._userManager.GetUserByLogin(Login.Text).UserId;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.DoLogin();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var reg = Program.Container.Resolve<RegisterForm>();
            reg.ShowDialog();
        }
    }
}
