using GesBancaire.Data;
namespace GesBancaire.Interfaces
{
    public class MouvementService : IMouvementService
    {
        private readonly BankContext _context;

        public MouvementService(BankContext context)
        {
            _context = context;
        }

        public void Debit(int compteId, decimal montant)
        {
            var compte = _context.Comptes.Find(compteId);
            if (compte != null)
            {
                compte.Solde -= montant;
                _context.SaveChanges();
            }
        }

        public void Credit(int compteId, decimal montant)
        {
            var compte = _context.Comptes.Find(compteId);
            if (compte != null)
            {
                compte.Solde += montant;
                _context.SaveChanges();
            }
        }

        public void Virment(int sourceCompteId, int destinationCompteId, decimal montant)
        {
            var sourceCompte = _context.Comptes.Find(sourceCompteId);
            var destinationCompte = _context.Comptes.Find(destinationCompteId);

            if (sourceCompte != null && destinationCompte != null)
            {
                sourceCompte.Solde -= montant;
                destinationCompte.Solde += montant;
                _context.SaveChanges();
            }
        }
    }
}
