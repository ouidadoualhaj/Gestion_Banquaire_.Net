using System.Collections.Generic;

namespace GesBancaire.Interfaces
{
    public interface ICompteService
    {
        Compte GetCompteById(int compteId);
        List<Compte> GetComptes();

        // Other interface methods...
    }
}
