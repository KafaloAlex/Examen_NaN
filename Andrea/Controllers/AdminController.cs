using Andrea.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Andrea.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Andrea.ViewModels;

namespace Andrea.Controllers
{
    public class AdminController : Controller
    {
        AndreaDbContext _context = new AndreaDbContext();
        // GET: Admin
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
        
        public ActionResult AddCategory()
        {
            var cat = _context.Categories.ToList(); 
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category cat)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ViewBag.Message = "Ok";
                    _context.Categories.Add(cat);
                    _context.SaveChanges();

                    ModelState.Clear();
                }
                return View();
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }



        //CRUD Blog Test
        public ActionResult AddPost()
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

        [HttpPost]
        public ActionResult AddPost(BlogPost post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Request.Files.Count > 0)
                    {
                        var file = Request.Files[0];
                        if (file != null && file.ContentLength > 0)//Vérifie que le fichier existe
                        {
                            var fileName = Path.GetFileName(file.FileName); //Récupération du nom du fichier
                            var path = Path.Combine(Server.MapPath("~/Fichier"), fileName);//Enregistrement du fichier dans le dossier Fichier
                            file.SaveAs(path);

                            post.Img_Blog = fileName;
                        }
                    }

                    post.Date_Post = DateTime.Now;
                    _context.BlogPosts.Add(post);
                    ViewBag.Message = "Ok";
                    _context.SaveChanges();


                }
                return RedirectToAction("AddPost");

            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }
        }


        public ActionResult DeletePost(int id)
        {
            try
            {
                BlogPost post = _context.BlogPosts.SingleOrDefault(c => c.Id_Blog == id);

                if (post != null)
                {
                    _context.BlogPosts.Remove(post);
                    _context.SaveChanges();
                }
                return RedirectToAction("AddPost");
            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }
        }

        //Modification d'un Post
        public ActionResult ModifyPost(int id)
        {
            try
            {
                ViewBag.PostList = _context.BlogPosts.ToList();

                BlogPost post = _context.BlogPosts.SingleOrDefault(c => c.Id_Blog == id);
                if (post != null)
                {
                    return View("AddPost", post);
                }
                return RedirectToAction("AddPost");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }

        //Sauvegarde la modification
        [HttpPost]
        public ActionResult ModifyPost(BlogPost post, int id)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _context.Entry(post).State = EntityState.Modified;
                    _context.SaveChanges();
                    ViewBag.Role = "Ok";
                }
                return RedirectToAction("AddPost");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }


        /*public ActionResult AddPost()
        {
            var cat = _context.Categories.ToList();
            var viewModel = new BlogViewModel
            {
                blogPost = new BlogPost(),
                categories = cat
            };

            return View("AddPost", viewModel);
        }*/


    }
}