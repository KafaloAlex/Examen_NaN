using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Andrea.Models
{
    public class About
    {
        [Key]
        public int Id_About { get; set; }

        public string Title_About { get; set; }

        public string Img_About { get; set; }

        public string Description_About { get; set; }
    }
}