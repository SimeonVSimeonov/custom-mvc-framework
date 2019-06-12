using SIS.MvcFramework;
using SIS.MvcFramework.Result;

namespace Musaca.App.Controllers
{
    public class UsersController : Controller
    {
        public UsersController()
        {

        }

        public ActionResult Login()
        {
            return this.View();
        }
    }
}
