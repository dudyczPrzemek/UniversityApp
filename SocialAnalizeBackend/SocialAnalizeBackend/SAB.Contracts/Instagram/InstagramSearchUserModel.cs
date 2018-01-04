using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Instagram
{
    public class InstagramSearchUserModel
    {
        public string id { get; set; }
        public string username { get; set; }
        public string profile_picture { get; set; }
        public string full_name { get; set; }
        public string bio { get; set; }
        public string website { get; set; }
        public bool is_business { get; set; }
    }
}
