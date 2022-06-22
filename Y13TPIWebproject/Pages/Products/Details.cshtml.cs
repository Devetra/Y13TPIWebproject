using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Y13TPIWebproject.Areas.Identity.Data;
using Y13TPIWebproject.Models;

namespace Y13TPIWebproject.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB _context;

        public DetailsModel(Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
