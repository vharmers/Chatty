﻿using System;
using System.Collections.Generic;

namespace Chatty.Model
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public string Message { get; set; }
        public long TimeStamp { get; set; }
        public string Identifier { get; set; }
        public bool GroupMessage { get; set; }
    }

    public class UserSearchEventArgs : EventArgs
    {
        public List<Client> FoundMembers { get; set; }
    }

    public class UserComfirmEventArgs : EventArgs
    {
        public string UserName { get; set; }
        public string PublicKey { get; set; }
    }

    public class GroupJoinedEventArgs : EventArgs
    {
        public string GroupName { get; set; }
        public string GroupHash { get; set; }
        public List<Client> Members { get; set; }
    }
}
