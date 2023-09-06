using Microsoft.AspNetCore.Mvc;
using TanITELEC1C.Models;

namespace TanITELEC1C.Controllers
{
    public class InstructorController : Controller
    {

        List<Instructor> InstructorList = new List<Instructor>()
        {

            new Instructor()
            {

                InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                InstructorEmail = "gdmontano@ust.edu.ph", Rank = Rank.Instructor

            },

            new Instructor()
            {

                InstructorName = "Leo Lintag", DateHired = DateTime.Parse("25/3/2000"),
                InstructorEmail = "Llintage@ust.edu.ph", Rank = Rank.AsstProf

            },

            new Instructor()
            {

                InstructorName = "Zyx Montano", DateHired = DateTime.Parse("25/3/2000"),
                InstructorEmail = "zmontano@ust.edu.ph", Rank = Rank.Prof


            },

        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
    }
}
