using System.Collections.Generic;
using System.Numerics;

namespace GesBancaire.Models
{
    public class CompteViewModel
    {
        public List<Compte> Comptes { get; set; }
        public Compte SelectedCompte { get; set; }
    }
}
