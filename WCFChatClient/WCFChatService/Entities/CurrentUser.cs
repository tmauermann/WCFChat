﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFChatService.Entities
{
    [DataContract]
    public class CurrentUser
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Gender { get; set; }
    }

}