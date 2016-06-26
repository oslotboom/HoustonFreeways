using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoustonFreeways.Models;
using System.Xml.Linq;


namespace HoustonFreeways.Controllers
{
    public class HomeController : Controller
    {
        public const int MAX_SEQUENCE = 15;

        public ActionResult Index()
        {
            ViewBag.Title = "Houston Freeways";


            return View(HoustonFreeways.Models.HomePage.BuildHomePageModel());
        }

        public ActionResult Preview()
        {
            ViewBag.Preview = RouteData.Values["id"].ToString().ToLower();
            return View();
        }

        public ActionResult Corrections()
        {
            return View();
        }

        public ActionResult PhotoIndex()
        {
            return View();
        }


        public ActionResult analysis()
        {
            return View();
        }

        public ActionResult analysis_sept_2015()
        {
            return View();
        }

        public ActionResult west_loop_bus_lanes()
        {
            return View();
        }

        public ActionResult us59_analysis()
        {
            return View();
        }

        public ActionResult Photos()
        {


            //The ID of the url is translated into an XML file and loaded into an object
            string requestId = RouteData.Values["id"].ToString().ToLower();
            string xmlFilePath = Request.PhysicalApplicationPath + "\\App_Data\\" + requestId + ".xml";
            XDocument photoXdoc = XDocument.Load(xmlFilePath);

            //define the image path
            string imageFolder = photoXdoc.Descendants("folderPath").SingleOrDefault().Value.ToString();
            if (requestId.Contains("1961"))
                ViewBag.ImagePath = System.Web.Configuration.WebConfigurationManager.AppSettings["ImagePathGoogleDrive"] + imageFolder + "/";
            else
                ViewBag.ImagePath = System.Web.Configuration.WebConfigurationManager.AppSettings["ImagePath"] + "images/" + imageFolder + "/";

            ViewBag.description = photoXdoc.Descendants("description").Count()==1 ? photoXdoc.Descendants("description").SingleOrDefault().Value.ToString(): "";
            return View(new PhotoList(photoXdoc));
        }


        public ActionResult Video()
        {
            return View();
        }


        public ActionResult Five_Year_Retrospective()
        {
            return View();
        }


        public ActionResult Sharpstown_History()
        {
            return View();
        }

        public ActionResult QuickView()
        {
            ViewBag.Message = "This is the quickview page";

            return View();
        }

        public ActionResult Author()
        {
            ViewBag.Message = "This is the Author page";
            ViewBag.Heading = "Author";
            ViewBag.Action = RouteData.Values["action"].ToString().ToLower();
            return View();
        }

        public ActionResult About()
        {

            ViewBag.Heading = "About the Book";
            ViewBag.Action = RouteData.Values["action"].ToString().ToLower();
            return View();
        }

        public ActionResult Chapters()
        {
            ViewBag.Title = "Chapters";
            ViewBag.Heading = "Chapters";
            ViewBag.Action = RouteData.Values["action"].ToString().ToLower();
            return View();
        }

        public ActionResult ErrorNotification()
        {
            return View();
        }

        public ActionResult Challenge()
        {
            string challenge = RouteData.Values["id"].ToString().ToLower();
            string item = RouteData.Values["item"].ToString().ToLower();
            int sequence = 0;
            //validate routeData values
            string[] validChallenge = new string[] { "aerial-1", "aerial-2", "aerial-3", "historical-beginner", "historical-intermediate", "historical-advanced" };
            if (!validChallenge.Contains(challenge) || !Int32.TryParse(item, out sequence) || sequence>MAX_SEQUENCE || sequence<0 )
                return RedirectToAction("ErrorNotification" );

            ChallengeItem objChallengeItem;

            switch (challenge)
            {
                case "aerial-1":
                    objChallengeItem = ChallengeItem.GetChallenge("aerial", 0, sequence-1, MAX_SEQUENCE, "Aerial Challenge 1, May 2002 Photos");
                    break;
                case "aerial-2":
                    objChallengeItem = ChallengeItem.GetChallenge("aerial", 1, sequence-1, MAX_SEQUENCE, "Aerial Challenge 2, September 2002 Photos");
                    break;
                case "aerial-3":
                    objChallengeItem = ChallengeItem.GetChallenge("aerial", 2, sequence-1, MAX_SEQUENCE, "Aerial Challenge 3, Nov 2002 and May 2003 Photos");
                    break;

                case "historical-beginner":
                    objChallengeItem = ChallengeItem.GetChallenge("historical", 0, sequence-1, MAX_SEQUENCE, "Historical Challenge, Easy");
                    break;
                case "historical-intermediate":
                    objChallengeItem = ChallengeItem.GetChallenge("historical", 1, sequence-1, MAX_SEQUENCE, "Historical Challenge, Intermediate Difficulty");
                    break;
                case "historical-advanced":
                    objChallengeItem = ChallengeItem.GetChallenge("historical", 2, sequence-1, MAX_SEQUENCE, "Historical Challenge, Advanced");
                    break;
                default:
                    return RedirectToAction("ErrorNotification");

            }

            return View(objChallengeItem); 
        }

    }
}
