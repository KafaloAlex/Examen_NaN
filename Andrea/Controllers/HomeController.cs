using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Andrea.DAL;
using Microsoft.EntityFrameworkCore;

namespace Andrea.Controllers
{
    public class HomeController : Controller
    {
        AndreaDbContext _context = new AndreaDbContext();

        public ActionResult Index()
        {
            try
            {
                ViewBag.PostList = _context.BlogPosts.Include(c => c.Id_Cat).ToList();
                return View();
            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }
        }


        public ActionResult DetailPost(int id)
        {
            var blog = _context.BlogPosts.SingleOrDefault(c => c.Id_Blog == id);

            if (blog == null)
                return HttpNotFound();

            return View(blog);
        }

    }
}