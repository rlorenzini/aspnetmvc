using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/
        //HelloWorldController is URL /HelloWorld/, anything() = /anything/
        //Under startup.cs, Index is set as the default action, meaning /Index/ or / loads Index()
        //NOTE: does not auto-update like React; must re-run to add changes to page (option+command+return)
        //website.com/[Controller]/[ActionName]/[Parameters]

        public string Index()
        {
            return "This is my default action...";
        }

        //
        //GET: /HelloWorld/Welcome/
        //Welcome() = /Welcome/

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}