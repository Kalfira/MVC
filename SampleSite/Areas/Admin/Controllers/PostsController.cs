using System.Web.Mvc;

namespace SampleSite.Areas.Admin.Controllers
{
    [Authorize(Roles="admin")]
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return View();
        }
    }
}