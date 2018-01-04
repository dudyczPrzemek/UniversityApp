using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Facebook
{
    public class FacebookSearchUserListResult
    {
        public FacebookSearchUserResult [] data { get; set; }
        public FacebookPagingObject paging { get; set; }
    }
}
