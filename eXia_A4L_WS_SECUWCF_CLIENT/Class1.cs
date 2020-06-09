using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eXia_A4L_WS_SECUWCF_CLIENT.proxy;

namespace eXia_A4L_WS_SECUWCF_CLIENT.M1_CUT
{
    public class CUT_AUTH
    {
        private STC_MSG msg;
        private eXia_A4L_WS_SECUWCF_CLIENT.M2_CUC.CUC cuc;

        public CUT_AUTH()
        {
            this.msg = new STC_MSG();
            this.cuc = new M2_CUC.CUC();
        }

        public STC_MSG m_auhentifier(STC_MSG msg)
        {
            this.msg = msg;
            this.msg.op_name = "Call from the CUC";
            this.msg = this.cuc.m_sendSVER(this.msg);

            return this.msg;
        }
    }
}
