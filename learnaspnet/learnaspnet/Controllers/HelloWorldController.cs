using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        // HelloWorldController is URL /HelloWorld/, anything() = /anything/
        // Under startup.cs, Index is set as the default action, meaning /Index/ or / loads Index()
        // NOTE: does not auto-update like React; must re-run to add changes to page (option+command+return)
        // website.com/[Controller]/[ActionName]/[Parameters]

        public string Index()
        {
            return "This is my default action..."; // MUST end in ; 
        }

        //
        // GET: /HelloWorld/Welcome/
        // Welcome() = /Welcome/
        // Requires using System.Text.Encodings.Web;
        // numTimes is set to default 1 if no input specified; string name needs an input
        // /HelloWorld/Welcome?name=Rick&numtimes=4
        // ? defines start of parameters, & connects multiple parameters

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}.");
        }
    }
}