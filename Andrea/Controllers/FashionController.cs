using Andrea.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andrea.Controllers
{
    public class FashionController : Controller
    {
        AndreaDbContext _context = new AndreaDbContext();

        // GET: Fashion
        public ActionResult Index()
        {
            try
            {
                ViewBag.PostList = _context.BlogPosts.ToList();
                return View();
            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }
        }

        /*public ActionResult DetailBlog(int id)
        {
            
        }*/
    }
}