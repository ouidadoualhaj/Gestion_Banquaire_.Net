using GesBancaire.Interfaces;
using GesBancaire.Models;
using Microsoft.AspNetCore.Mvc;

public class MouvementController : Controller
{
    private readonly ICompteService _compteService;

    public MouvementController(ICompteService compteService)
    {
        _compteService = compteService;
    }

    // GET: /Mouvement/Index
    public IActionResult Index()
    {
        var comptes = _compteService.GetComptes(); // Explicitly convert to List<Compte>
        var mouvementViewModel = new MouvementViewModel
        {
            Comptes = comptes
        };

        return View(mouvementViewModel);
    }

    // POST: /Mouvement/Index
    [HttpPost]
    public IActionResult Index(MouvementViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            // Process the form submission based on the selected operation and montant
            // Access selected Compte using viewModel.compteId

            // Redirect to a success page or perform additional actions
            return RedirectToAction("Success");
        }

        // If the model state is not valid, redisplay the form with the existing data
        return View(viewModel);
    }

    // GET: /Mouvement/Success
    public IActionResult Success()
    {
        return View();
    }
}
