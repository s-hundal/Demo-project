using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wk2_1_Razor_DbFirst.Models;

namespace Wk2_1_Razor_DbFirst.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Wk2_1_Razor_DbFirst.Models.SchoolDbContext _context;

        public CreateModel(Wk2_1_Razor_DbFirst.Models.SchoolDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StandardId"] = new SelectList(_context.Standards, "StandardId", "StandardId");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
