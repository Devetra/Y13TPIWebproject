using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Y13TPIWebproject.Areas.Identity.Data;
using Y13TPIWebproject.Models;

namespace Y13TPIWebproject.Pages.Checkouts
{
    public class DeleteModel : PageModel
    {
        private readonly Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB _context;

        public DeleteModel(Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB context)
        {
            _context = context;
        }

        [BindProperty]
      public Checkout Checkout { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Checkout == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkout.FirstOrDefaultAsync(m => m.CheckoutID == id);

            if (checkout == null)
            {
                return NotFound();
            }
            else 
            {
                Checkout = checkout;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Checkout == null)
            {
                return NotFound();
            }
            var checkout = await _context.Checkout.FindAsync(id);

            if (checkout != null)
            {
                Checkout = checkout;
                _context.Checkout.Remove(Checkout);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
