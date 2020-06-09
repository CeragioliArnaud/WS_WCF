using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using eXia_A4L_WS_SECUWCF_CLIENT.proxy;

namespace eXia_A4L_WS_SECUWCF_CLIENT.M2_CUC
{
    public class CUC
    {

        private proxy.STC_MSG msg;
        private proxy.E2*******************; prox;
        
        public CUC()
        {
            this.msg = new STC_MSG();
            this.prox = new E2*******************.Client();

        }

        public STC_MSG m_sendSVER(STC_MSG msg)
        {
            this.msg = msg;
            this.msg.app_name = "Appli1";
            this.msg.app_token = "12345";
            this.msg.app_version = "10";
            this.msg.op_info = "Demande de service de l'application 1 de version 1.0";

            this.msg = this.prox.m_server(this.msg);

            return this.msg;
        }
    }
}