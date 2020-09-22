using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Andrea.Models
{
    public class Comment
    {
        [Key]
        public int Id_Comment { get; set; }

        public string Comment_Name { get; set; }
        public string Comment_Mail { get; set; }
        public string Comment_WebSite { get; set; }
        public string Comment_Msg { get; set; }
        public DateTime Comment_DatePost { get; set; }

        //Foreign Key
        public BlogPost blogPost { get; set; }

        public ICollection<Reply> replies { get; set; }
    }
}