using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Andrea.Models
{
    public class Contact_Info
    {
        [Key]
        public int Id_Info { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public string Website { get; set; }
    }
}