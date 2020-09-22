using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Andrea.Models;

namespace Andrea.ViewModels
{
    public class BlogViewModel
    {
        public BlogPost blogPost { get; set; }
        public IEnumerable<Category> categories { get; set; }
    }
}