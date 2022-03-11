using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Admin.Students
{
    public class DeconnexionModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
                return Redirect("./Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
