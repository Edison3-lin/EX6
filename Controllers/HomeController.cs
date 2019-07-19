using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EX6.Controllers
{
    public class HomeController : Controller
    {
//------------- Index() -------------
        public ActionResult Index()
        {
            //Initial data，部門
            ViewBag.Page = 1;
            ViewBag.name = "姓名: ";
            ViewBag.department = "部門: ";
            ViewBag.sex = "性別: ";
            ViewBag.male = " 男";
            ViewBag.female = " 女";
            IDictionary<string, string> DepL = new Dictionary<string, string>();
            DepL.Add("BU5", "BU5");
            DepL.Add("BU6", "BU6");
            DepL.Add("BU7", "BU7");
            DepL.Add("BU8", "BU8");
            DepL.Add("BU9", "BU9");
            //DropDownList default "BU8"
            SelectList DepList = new SelectList(DepL, "Key", "Value", "BU8");
            ViewData["BU"] = DepList; 
            return View();
        }
        [HttpPost]
        public ActionResult Index(string BU,string TextBox1,string Gender,string xGender)
        {
            //View()頁面key-in的data，傳送至第二頁面Edit()
            ViewBag.Page = 2;
            ViewBag.name = "姓名: ";
            ViewBag.department = "部門: ";
            ViewBag.sex = "性別: ";
            ViewBag.male = " 男";
            ViewBag.female = " 女";
            TempData["eBU"]=BU;
            TempData["eTextBox1"]=TextBox1;
            TempData["eGender"]=Gender;
            TempData["fGender"]=xGender;
            IDictionary<string, string> DepL = new Dictionary<string, string>();
            DepL.Add("BU5", "BU5");
            DepL.Add("BU6", "BU6");
            DepL.Add("BU7", "BU7");
            DepL.Add("BU8", "BU8");
            DepL.Add("BU9", "BU9");
            //DropDownList default "BU8"
            SelectList DepList = new SelectList(DepL, "Key", "Value", BU);
            ViewData["BU"] = DepList;
            if (xGender == "xyz")
                return View();
            else
                return RedirectToAction("Final");
        }

/*
        public ActionResult _Name(int id)
        {
            ViewBag.id = id;
            return PartialView("_Name");
        }
*/
        public ActionResult Final()
        {
            Response.Write("<h2>和碩聯合科技員工");
            Response.Write("<br><h3>[部門:] ");
            Response.Write(TempData["eBU"]);
            Response.Write("<hr>[姓名:] ");
            Response.Write(TempData["eTextBox1"]);
            Response.Write("<hr>[性別:] ");
            Response.Write(TempData["fGender"]);
          
            return null;
        }
    }
 }