using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using demowebapp.Models;

namespace demowebapp.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly demowebapp.Models.PersonContext _context;

        public IndexModel(demowebapp.Models.PersonContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
