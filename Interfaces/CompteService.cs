using System.Collections.Generic;
using GesBancaire.Models;
using GesBancaire.Interfaces;
using GesBancaire.Data;
using System.Linq;


namespace GesBancaire.Services
{
    public class CompteService : ICompteService
    {
        private readonly BankContext _context;

        public CompteService(BankContext context)
        {
            _context = context;
        }

        public List<Compte> GetComptes()
        {
            return _context.Comptes.ToList();
        }

        public Compte GetCompteById(int compteId)
        {
            return _context.Comptes.Find(compteId);
        }
    }
}
