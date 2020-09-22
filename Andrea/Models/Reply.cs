using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andrea.Models
{
    public class Reply
    {
        [Key]
        public int Id_Reply { get; set; }


        public string Reply_Name { get; set; }
        public string Reply_Mail { get; set; }
        public string Reply_Msg { get; set; }
        public string Reply_DatePost { get; set; }

        public int Id_Comment { get; set; }
        public Comment comment { get; set; }
    }
}