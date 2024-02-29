using Microsoft.AspNetCore.Mvc;
using Quiz_1.Models;

namespace Quiz_1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int year, int month, string slug)
        {
            //var blogmodel = new BlogModel();

            //if(slug == "blog1")
            //{
                
            //}
            //else if (slug == "blog2")
            //{
            //    BlogModel
            //        {
            //        Content = "Blog1";
            //    }
            //}
            //else if (slug == "blog3")
            //{
            //    BlogModel
            //        {
            //        Content = "Blog1";
            //    }
            //}
            //else if (slug == "blog4")
            //{
            //    BlogModel
            //        {
            //        Content = "Blog1";
            //    }
            //}
            //else if (slug == "blog5")
            //{
            //    BlogModel
            //        {
            //        Content = "Blog1";
            //    }
            //}
            //else
            //{
            //    return View();
            //}
            //return View(blogmodel);

            return View();
        }

    }
}
