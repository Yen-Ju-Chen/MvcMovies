using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


//命名為 HelloWorldController就可使用以下方法設定url
//controller, action, id
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //呼叫view層
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

