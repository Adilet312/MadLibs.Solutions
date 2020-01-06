using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
namespace MadLibs.Controllers
{
    public class HomeController: Controller
    {

        [Route("/")]
        public ActionResult MainPage() { return View(); }
        [Route("/formPath")]
        public ActionResult Form() { return View(); }
        

        [Route("/storyPath")]
        public ActionResult Story(string person_name,string reciver_name, string adjective, string noun, string verb)
        {
            Words myLetterVariable = new Words(person_name,reciver_name,adjective,noun,verb);
            return View(myLetterVariable);
        }

        [Route("/formPath2")]
        public ActionResult Form2() { return View(); }

        [Route("/storyPath2")]
        public ActionResult Story2(string person_name,string noun, string verb)
        {
            Words myLetterVariable = new Words(person_name,noun,verb);
            return View(myLetterVariable);
        }
    }

}