using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        DataContext d;

        public IndexModel(ILogger<IndexModel> logger,DataContext data)
        {
            _logger = logger;
            d = data;
        }

        public void OnGet()
        {
            //var etu = new Etudiant() { nom = "imane" };
            //d.Etudiants.Add(etu);
            //d.SaveChanges();

        }
    }
}
