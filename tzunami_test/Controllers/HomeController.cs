using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tzunami_test.DAL;
using tzunami_test.Infa;
using tzunami_test.Models;

namespace tzunami_test.Controllers
{
    public class HomeController : BaseController
    {
        

        public ActionResult Index()
        {
            

            return View();
        }

        [HttpGet]
        public JsonResult GetUsers()
        {
            var data = UsersFactory.Users.GetUsers();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Delete(long ID)
        {
            UsersFactory.Users.DeleteUser(ID);
            var data = UsersFactory.Users.GetUsers();
            return Json(data, JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public JsonResult UpdateUser(BaseUser entity)
        {
            if (ModelState.IsValid)
            {
                UsersFactory.Users.InsertUser(entity);
                var data = UsersFactory.Users.GetUsers();
                return Json(data, JsonRequestBehavior.DenyGet);
            }
            else
            {
                var errors = GetErrorsFromModelState();
                return Json(new { errors = errors }, JsonRequestBehavior.DenyGet);
            }
            
        }
        [HttpGet]
        public JsonResult GetUserTypes() {
            var data = Enum.GetNames(typeof(UserType)).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Details(long ID)
        {
            var entity = UsersFactory.Users.GetUserByID(ID);
            return View(entity);
        }

        [HttpGet]
        public ActionResult Edit(long ID)
        {
            
            var entity = UsersFactory.Users.GetUserByID(ID);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(BaseUser entity)
        {
            UsersFactory.Users.UpdateUser(entity);
            return RedirectToAction("Index");
        }
    }
}
