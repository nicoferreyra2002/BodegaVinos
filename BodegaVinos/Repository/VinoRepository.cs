using BodegaVinos.Entities;

namespace BodegaVinos.Repository
{
    public class VinoRepository
    {
        private readonly List<Vino> _vinos;

        public VinoRepository()
        {
            _vinos = new List<Vino>
                {
                    new Vino
                    {
                        Id = 1,
                        Name = "Rutini Malbec",
                        Variety = "Malbec",
                        Year = 2019,
                        Region = "Mendoza",
                        Stock = 120
                    },
                    new Vino
                    {
                        Id = 2,
                        Name = "Cordero con Piel de Lobo Cabernet Sauvignon",
                        Variety = "Cabernet Sauvignon",
                        Year = 2020,
                        Region = "San Juan",
                        Stock = 200
                    },
                    new Vino
                    {
                        Id = 3,
                        Name = "Luigi Bosca Chardonnay",
                        Variety = "Chardonnay",
                        Year = 2021,
                        Region = "Mendoza",
                        Stock = 95
                    },
                    new Vino
                    {
                        Id = 4,
                        Name = "Finca Las Moras Syrah",
                        Variety = "Syrah",
                        Year = 2016,
                        Region = "San Juan",
                        Stock = 130
                    },
                    new Vino
                    {
                        Id = 5,
                        Name = "Catena Zapata Adrianna Vineyard Malbec",
                        Variety = "Malbec",
                        Year = 2015,
                        Region = "Mendoza",
                        Stock = 70
                    }
                };
        }

        public List<Vino> GetVinos() => _vinos;

        public Vino GetVinoByName(string name)
        {
            return _vinos.FirstOrDefault(v => v.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ?? throw new ArgumentNullException(nameof(name));
        }

        public void AddVino(Vino vino)
        {
            _vinos.Add(vino);
        }

        public void UpdateVino(Vino vino)
        {
            var existingVino = GetVinoByName(vino.Name);
            if (existingVino != null)
            {
                existingVino.Variety = vino.Variety;
                existingVino.Year = vino.Year;
                existingVino.Region = vino.Region;
                existingVino.Stock = vino.Stock;
            }
        }
    }
}
