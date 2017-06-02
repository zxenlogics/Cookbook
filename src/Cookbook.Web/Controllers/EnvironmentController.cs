using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC.Internal.DevOps.Presentation.UI.MCWebApp.Models;

namespace MC.Internal.DevOps.Presentation.UI.MCWebApp.Controllers
{
    public class EnvironmentController : Controller
    {
        // GET: Environment
        public ActionResult List()
        {
            return View("List", EnvironmentsDataProvider.GetEnvironments());
        }

        [ValidateInput(false)]
        public ActionResult EnvironmentGridViewPartial()
        {
            var model = EnvironmentsDataProvider.GetEnvironments();
            return PartialView("_EnvironmentGridViewPartial", model);
        }

        [ValidateInput(false)]
        public ActionResult EnvironmentMenuPartial(string host)
        {
            var model = EnvironmentsDataProvider.GetEnvironments();
            return PartialView("_EnvironmentMenuPartial", host);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EnvironmentGridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] MC.Internal.DevOps.Presentation.UI.MCWebApp.Models.EnvironmentViewModel item)
        {
            var model = EnvironmentsDataProvider.GetEnvironments();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_EnvironmentGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EnvironmentGridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] MC.Internal.DevOps.Presentation.UI.MCWebApp.Models.EnvironmentViewModel item)
        {
            var model = EnvironmentsDataProvider.GetEnvironments();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_EnvironmentGridViewPartial", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EnvironmentGridViewPartialDelete(System.String Host)
        {
            var model = EnvironmentsDataProvider.GetEnvironments();
            if (Host != null)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_EnvironmentGridViewPartial", model);
        }
    }
}
