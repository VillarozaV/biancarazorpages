#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using biancarazorpages.Data;

namespace biancarazorpages.Pages.bianca
{
    public class IndexModel : PageModel
    {
        private readonly biancarazorpages.Data.biancarazorpagesContext _context;

        public IndexModel(biancarazorpages.Data.biancarazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
