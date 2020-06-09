using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace eXia_A4L_WS_SECUWCF_SERVWCF_CONTRACT
{
    [ServiceContract]

    public interface iSVR
    {
        [System.ServiceModel.OperationContract]
        STC_MSG m_service(STC_MSG msg);
    }
    [DataContract]
    public struct STC_MSG
    {
        [System.Runtime.Serialization.DataMember]
        public bool op_statut;
        [System.Runtime.Serialization.DataMember]
        public string op_name;
        [System.Runtime.Serialization.DataMember]
        public string op_info;
        [System.Runtime.Serialization.DataMember]
        public string app_name;
        [System.Runtime.Serialization.DataMember]
        public string app_version;
        [System.Runtime.Serialization.DataMember]
        public string app_token;
        [System.Runtime.Serialization.DataMember]
        public string user_login;
        [System.Runtime.Serialization.DataMember]
        public string user_psw;
        [System.Runtime.Serialization.DataMember]
        public string user_token;
        [System.Runtime.Serialization.DataMember]
        public object[] data;
    }
}

