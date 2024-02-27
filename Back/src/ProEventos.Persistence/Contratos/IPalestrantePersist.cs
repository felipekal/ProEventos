using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {

        //PALESTRANTES

        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string tema, bool includeEventos);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos);

    }   
}