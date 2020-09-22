using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Andrea.Models
{
    public class Category
    {
        [Key]
        public int Id_Cat { get; set; }

        public string Name_Cat { get; set; }

        public virtual ICollection<BlogPost> blogPosts { get; set; }
    }
}