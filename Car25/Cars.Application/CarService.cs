using Cars.Core;
using Cars.Data;
using System.Collections.Generic;
using System.Linq;

namespace Cars.ApplicationServices
{
    public class CarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public IEnumerable<Car> FilterCarsByMake(string make)
        {
            return _context.Cars.Where(c => c.Make == make).ToList();
        }
    }
}
