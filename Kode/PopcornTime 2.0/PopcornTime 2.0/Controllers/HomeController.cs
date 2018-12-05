﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PopcornTime_2._0.ServiceLayer;
using PopcornTime_2._0.Models;

namespace PopcornTime_2._0.Controllers
{
    public class HomeController : Controller
    {
        //foran en metode kan der skrives []httpPost
        private EntertainmentService eS;
        //private Entertainment entertainment;
        public HomeController()
        {
            eS = new EntertainmentService();
            //entertainment = new Entertainment();
        }
        public ActionResult Index()
        {
            List<Entertainment> entertainments;
            
            entertainments = eS.GetEntertainments();
            //Entertainment entertainment = new Entertainment(string title, DateTime releaseDate);
            //Entertainment[] ents;

            //using (var client = new TimeSlotServiceClient())
            //{
            //    tSlots = await client.FindAllUnoccupiedAsync();
            //}

            //return View(tSlots.ToList());
            return View(entertainments);
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Friends()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Series()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}