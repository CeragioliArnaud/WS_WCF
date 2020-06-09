using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eXia_A4L_WS_SECUWCF_CLIENT.proxy;

namespace eXia_A4L_WS_SECUWCF_CLIENT
{
    public partial class frm_auth : Form
    {
        private STC_MSG msg;
        private eXia_A4L_WS_SECUWCF_CLIENT.M1_CUT.CUT_AUTH cutAuth;
        public frm_auth()
        {
            InitializeComponent();
        }

        private void frm_auth_Load(object sender, EventArgs e)
        {
            this.msg = new STC_MSG();
            this.cutAuth = new M1_CUT.CUT_AUTH();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            this.txt_information.Clear();
            if ((this.txt_login.Text != "") && (this.txt_password.Text != ""))
            {
                this.msg.user_login = this.txt_login.Text;
                this.msg.user_psw = this.txt_password.Text;

                this.msg = this.cutAuth.m_auhentifier(this.msg);

                if (this.msg.op_statut == true)
                {
                    this.txt_information.Text = "Vous êtes connectés";
                }
                else
                {
                    this.txt_information.Text = "Vous n'êtes pas connectés";
                }

            }
            else
            {
                this.txt_information.Text = "Veuillez renseigner tous les champs";
            }

        }
    }
}
