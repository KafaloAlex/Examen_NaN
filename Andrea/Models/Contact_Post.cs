using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Andrea.Models
{
    public class Contact_Post
    {
        [Key]
        public int Id_Contact { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }


        public string Subject { get; set; }


        public string Msg_Contact { get; set; }
    }
}