using GesBancaire.Interfaces;
using GesBancaire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GesBancaire.Controllers
{
    public class CompteController : Controller
    {
        private readonly ICompteService _compteService;

        public CompteController(ICompteService compteService)
        {
            _compteService = compteService;
        }

        public IActionResult GetCompte(int compteId)
        {
            var compte = _compteService.GetCompteById(compteId);

            if (compte == null)
            {
                return NotFound();
            }

            return View(compte);
        }
        
    }
}
