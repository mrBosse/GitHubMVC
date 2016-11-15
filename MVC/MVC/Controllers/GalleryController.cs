using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using MVC.Models;

namespace MVC.Controllers
{
    public class GalleryController : Controller
    {
        static List<Photo> photos = new List<Photo>();
        // GET: Gallery
        public GalleryController()
        {
            if (!photos.Any())
            {
                photos.Add(new Photo {PhotoName = "1McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "2McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "3McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "4McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "5McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "6McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "7McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "8McGregor.jpg"});
                photos.Add(new Photo {PhotoName = "9McGregor.jpg"});


            }
           
    }

        public ActionResult Gallery()
        {
            return View(photos);
        }

        public ActionResult showphoto(int id)
        {
            var showphoto = photos.ElementAt(id);
            return View(showphoto);
             
        }
    }
}