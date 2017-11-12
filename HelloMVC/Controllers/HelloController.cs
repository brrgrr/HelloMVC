using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html =
                "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
            //return Redirect("/Hello/Goodbye");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // /Hello/Goodbye
        // alter route to /Hello/Aloha
        [Route("/Hello/Goodbye")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
 
        // Handle requests to /Hello/Eric (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }


    }
    public class GoodbyeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Goodbye!</h1>", "text/html");
        }
    }
}
