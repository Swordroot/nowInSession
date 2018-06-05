using System;
namespace nowInSession
{
    public class Invitation
    {
        public ulong senderUserId { get; set; }
        public string senderUserName { get; set; }
        public string senderDisplayName { get; set; }
        public ulong recieverUserId { get; set; }
        public string recieverUserName { get; set; }
        public string recieverDisplayName { get; set; }
        public string restaurantName { get; set; }
        public string restaurantURL { get; set; }
        public string comment { get; set; }

        //---for mock---
        public ulong userId { get; set; }
        public string userName { get; set; }
        public string displayName { get; set; }
    }
}
