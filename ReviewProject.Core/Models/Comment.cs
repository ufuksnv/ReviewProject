using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject.Core.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }


        public int GameId { get; set; }
        public Game Game { get; set; }


    }
}
