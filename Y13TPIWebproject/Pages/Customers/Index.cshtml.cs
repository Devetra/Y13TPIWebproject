﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Y13TPIWebproject.Areas.Identity.Data;
using Y13TPIWebproject.Models;

namespace Y13TPIWebproject.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB _context;

        public IndexModel(Y13TPIWebproject.Areas.Identity.Data.Y13TPIWebprojectContextDB context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customer != null)
            {
                Customer = await _context.Customer.ToListAsync();
            }
        }
    }
}