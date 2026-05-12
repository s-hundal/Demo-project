using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wk2_1_Razor_DbFirst.Models;

namespace Wk2_1_Razor_DbFirst.Pages.Students
{
    public class StudentIndexModel : PageModel
    {

        private SchoolDbContext _context;

        public StudentIndexModel(SchoolDbContext context)
        {
            _context = context;
        }


        public IList<Student> Students { get; set; }


        //Fetch students from db adn save it in a property
        public async  Task OnGet()
        {
           Students=  await _context.Students.ToListAsync();

        }
    }
}
