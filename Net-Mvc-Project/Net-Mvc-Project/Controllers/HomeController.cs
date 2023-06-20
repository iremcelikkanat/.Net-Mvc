using BusinessLayer;
using BusinessLayer.Test;
using Entities;
using Net_Mvc_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Test test =new Test();
            ////test.List();
            //test.Insert();
            PostManager post = new PostManager();
            ViewBag.GetPost = post.GetPosts().OrderByDescending(x => x.ModifyTime).ToList();
            return View(ViewBag.GetPost);
        }
        public ActionResult GetTag(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TagManager tagManager = new TagManager();
            Tag tgm = tagManager.GetTag(id.Value);
            if (tgm == null)
            {
                return HttpNotFound();
            }
            return View("Index", tgm.Posts.OrderByDescending(x => x.ModifyTime).ToList());
        }
        public ActionResult MostLike()
        {
            PostManager post = new PostManager();

            ViewBag.GetPost = post.GetPosts().OrderByDescending(x => x.LikeCount).ToList();
            return View("Index", ViewBag.GetPost);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}