using ReviewProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject.Core.DTOs
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string content { get; set; }      
        public bool Status { get; set; }


        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
