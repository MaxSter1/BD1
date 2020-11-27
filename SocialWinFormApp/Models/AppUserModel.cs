using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWinFormApp.Models
{
    public class AppUserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string UserLastName { get; set; }

        public List<string> Interests { get; set; }

        public List<int> FollowedIdList { get; set; }
    }
}
