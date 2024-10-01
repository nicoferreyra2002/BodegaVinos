using BodegaVinos.Dtos;
using BodegaVinos.Entities;
using BodegaVinos.Repository;

namespace BodegaVinos.Services
{
    public class VinoService : IVinoService
    {
        private readonly VinoRepository _repository;

        public VinoService(VinoRepository repository)
        {
            _repository = repository;
        }

        public List<VinoDtos> GetAllVinos()
        {
            var vinos = _repository.GetVinos();
            return vinos.Select(v => new VinoDtos
            {
                Name = v.Name,
                Variety = v.Variety,
                Year = v.Year,
                Region = v.Region,
                Stock = v.Stock
            }).ToList();
        }

        public VinoDtos GetVinoByName(string name)
        {
            var vino = _repository.GetVinoByName(name);
            if (vino == null)
                return null;

            return new VinoDtos
            {
                Name = vino.Name,
                Variety = vino.Variety,
                Year = vino.Year,
                Region = vino.Region,
                Stock = vino.Stock
            };
        }

        public void RegisterWine(VinoDtos vinoDto)
        {
            var vino = new Vino
            {
                Name = vinoDto.Name,
                Variety = vinoDto.Variety,
                Year = vinoDto.Year,
                Region = vinoDto.Region,
                Stock = vinoDto.Stock
            };

            _repository.AddVino(vino);
        }
        public void AddStock(string name, int quantity)
        {
            var vino = _repository.GetVinoByName(name);
            if (name != null)
            {
                vino.Stock += quantity;
                _repository.UpdateVino(vino);
            }
            else
            {
                throw new Exception($"El vino {name} no esta en el inventario");
            }
        }

        public VinoDtos GetVinoByName(int id)
        {
            throw new NotImplementedException();
        }

        public void RegisterVino(VinoDtos vinoDto)
        {
            throw new NotImplementedException();
        }
    }
}
