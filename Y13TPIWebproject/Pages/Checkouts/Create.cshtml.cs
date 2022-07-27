﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Y13TPIWebproject.Areas.Identity.Data;
using Y13TPIWebproject.Models;

namespace Y13TPIWebproject.Pages.Checkouts
{
    public class CreateModel : PageModel
    {
        private readonly Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB _context;

        public CreateModel(Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Checkout Checkout { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Checkout == null || Checkout == null)
            {
                return Page();
            }

            _context.Checkout.Add(Checkout);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
