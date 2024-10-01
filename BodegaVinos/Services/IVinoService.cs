using BodegaVinos.Dtos;

namespace BodegaVinos.Services
{
    public interface IVinoService
    {
        List<VinoDtos> GetAllVinos();
        VinoDtos GetVinoByName(string name);

        void RegisterVino(VinoDtos vinoDto);

        void AddStock(string name, int quantify);

    }
}
