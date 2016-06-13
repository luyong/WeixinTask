using System.Web.Mvc;
using Deepleo.Weixin.SDK;
using SimpleTaskSystem.WebSpaAngular.Attributes;

namespace SimpleTaskSystem.WebSpaAngular.Controllers
{
    [WeixinOAuthAuthorize]
    public class HomeController : SimpleTaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}