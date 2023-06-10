using System;
using System.Collections.Generic;

namespace GesBancaire
{
    public class Compte
    {
        public int CompteId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public decimal Solde { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Mouvement> Mouvements { get; set; }
    }
}
