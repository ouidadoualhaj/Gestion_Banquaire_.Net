using System.Collections.Generic;

namespace GesBancaire.Models
{
    public class MouvementViewModel
    {
        public List<Compte> Comptes { get; set; } // List of Comptes for the select dropdown
        public string Operation { get; set; } // The selected operation (credit, debit, virement)
        public decimal Montant { get; set; } // The entered montant value
    }

}
