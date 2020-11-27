using MongoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWinFormApp.Models
{
    public class AppPostModel
    {
        public int PostId { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
