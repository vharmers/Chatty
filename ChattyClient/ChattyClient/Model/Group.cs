﻿using System.Collections.Generic;

namespace ChattyClient.Model
{
    public class Group {
        public string GroupId { get; set; }
        public ChatHistory History { get; set; }
        public HashSet<Client> ClientList { get; set; }
    }
}
