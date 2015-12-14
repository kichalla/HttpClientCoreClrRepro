using System.Linq;
using System.Text;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Primitives;

namespace WebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Action1()
        {
            Response.Cookies.Append("foo", "bar");

            return RedirectToAction("Action2");
        }

        public IActionResult Action2()
        {
            var sb = new StringBuilder();
            foreach (var cookie in Request.Cookies)
            {
                sb.Append($"{cookie.Key}:{cookie.Value}, ");
            }

            return Content(sb.ToString());
        }
    }
}
