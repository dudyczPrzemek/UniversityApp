using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.User
{
    public class SearchUserUnitModel
    {
        public int UserId { get; set; }
        public string FacebookId { get; set; }
        public string InstagramId { get; set; }
        public string TwitterId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhotoUrl { get; set; }
        public string Paging { get; set; }
    }
}
