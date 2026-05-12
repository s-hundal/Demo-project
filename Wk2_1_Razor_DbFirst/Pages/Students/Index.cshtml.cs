using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wk2_1_Razor_DbFirst.Models;

namespace Wk2_1_Razor_DbFirst.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Wk2_1_Razor_DbFirst.Models.SchoolDbContext _context;

        public IndexModel(Wk2_1_Razor_DbFirst.Models.SchoolDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students
                .Include(s => s.Standard).ToListAsync();
        }
    }
}
