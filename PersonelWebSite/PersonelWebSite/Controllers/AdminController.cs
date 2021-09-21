using PersonelWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }

        public ActionResult HomePageEdit(int id)
        {
            var hpe = c.HomePages.Find(id);
            return View("HomePageEdit", hpe);
        }

        public ActionResult HomePageUpdate(HomePage x)
        {
            var hpu = c.HomePages.Find(x.PersonID);
            hpu.Name = x.Name;  /*  değişkenden aldığım ismi (hpu.Name) veri tabanından aldığım isme (x.Name) eşitle */
            hpu.PPhoto = x.PPhoto;
            hpu.Title = x.Title;
            hpu.Text = x.Text;
            hpu.Contact = x.Contact;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IconList()
        {
            var value = c.Icons.ToList();
            return View(value);
        }

        // HttpGet sayfa yüklendiğinde çalış

        [HttpGet]
        public ActionResult NewIcon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewIcon(Icon x)
        {
            c.Icons.Add(x);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }

        public ActionResult IconEdit(int id)
        {
            var ie = c.Icons.Find(id);
            return View("IconEdit", ie); /* return View("IconUpdate", ie);  değil dikkatt!!! view'in içerisinde Html.BeginForm içerisinde IconUpdate'e yönlendiriyor*/
        }

        public ActionResult IconUpdate(Icon x)
        {
            var iu = c.Icons.Find(x.IconID);
            iu.IconName = x.IconName;   /*  değişkenden aldığım ismi (iu.IconName) veri tabanından aldığım isme (x.IconName) eşitle */
            iu.Link = x.Link;
            c.SaveChanges();
            return RedirectToAction("IconList");
        }

        public ActionResult IconDelete(int id)
        {
            var idel = c.Icons.Find(id);
            c.Icons.Remove(idel);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }
    }
}