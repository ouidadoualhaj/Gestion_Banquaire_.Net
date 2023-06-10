namespace GesBancaire.Interfaces
{

    public interface IMouvementService
    {
        void Debit(int compteId, decimal montant);
        void Credit(int compteId, decimal montant);
        void Virment(int sourceCompteId, int destinationCompteId, decimal montant);
    }
}
