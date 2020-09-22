using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Andrea.Models
{
    public class BlogPost
    {
        [Key]
        public int Id_Blog { get; set; }

        public string Title_Blog { get; set; }

        public string Description_Blog { get; set; }

        public string Img_Blog { get; set; }

        public string Blogger_Name { get; set; }

        public string Blogger_Img { get; set; }

        public string Blogger_Description { get; set; }

        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }
        public string Tag4 { get; set; }
        public string Tag5 { get; set; }
        public string Tag6 { get; set; }

        public DateTime Date_Post { get; set; }


        //Foreign Key
        public int Id_Cat { get; set; }
        public Category category { get; set; }


        public ICollection<Comment> comments { get; set; }
    }
}