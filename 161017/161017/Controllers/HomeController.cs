﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _161017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult welcome()
        {
            var a = 100;
            var sum = 0;
            for (var i = 1; i <= a; i++)
            {
                sum += i;
            }

            ViewBag.sum = sum;
            return View();
            return View();
        }

     
        public ActionResult list(int page = 10)
        {
            string[] data = new string[] {
                "李克强：奋力开创东北全面振兴新局面","神十一与天宫对接成功 航天员“入宫”","这些作品影响习近平数十年"
            };
            ViewBag.data = data;
            ViewBag.Page = page;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Add()
        {
            

            return View();
        }
        public ActionResult Save(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }
    }
}