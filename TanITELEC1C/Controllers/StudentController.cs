using Microsoft.AspNetCore.Mvc;
using TanITELEC1C.Models;

namespace TanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            Student st = new Student();
            st.StudentId = 2021159607;
            st.StudentName = "John Paolo Tan";
            st.DateEnrolled = DateTime.Parse("30/08/2023");
            st.Course = Course.BSIT;
            st.Email = "johnpaolo.tan.cics@ust.edu.ph";

            ViewBag.Student = st;
            return View();
        }
    }
}
