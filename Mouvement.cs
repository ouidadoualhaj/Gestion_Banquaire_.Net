using System;

namespace GesBancaire
{
    public class Mouvement
    {
        public int MouvementId { get; set; }
        public decimal Montant { get; set; }
        public DateTime DateMvt { get; set; }
        public int CompteId { get; set; }
        public Compte Compte { get; set; }
    }
}
