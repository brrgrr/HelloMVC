using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class BonjourController : Controller
    {
      
        [HttpGet]
        public IActionResult Index()
        {

            var form = "<form method='post'>" +
                "<input name='name' type='text'/>" +
                "<select name='language'>" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='german'>German</option>" +
                "<option value='hebrew'>Hebrew</option>" +
                "<option value='italian'>Italian</option>" +
                "<option value='spanish'>Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Content(form, "text/html");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            var text = CreateMessage(name, language);
            return Content(string.Format("<h1>{0}</h1>", text), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting;
            if (language == "french")
            {
                greeting = "Bonjour";
            }
            else if (language == "german")
            {
                greeting = "Hallo";
            }
            else if (language == "hebrew")
            {
                greeting = "Shalom";
            }
            else if (language == "italian")
            {
                greeting = "Ciao";
            }
            else if (language == "spanish")
            {
                greeting = "Hola";
            }
            else //if (language == "english")
            {
                greeting = "Hello";
            }

            return greeting + " " + name;
        }
        

    }
}