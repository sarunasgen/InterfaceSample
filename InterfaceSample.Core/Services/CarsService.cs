using InterfaceSample.Core.Contracts;
using InterfaceSample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Services
{
    public class CarsService : ICarsService
    {
        private List<Car> AllCars = new List<Car>();
        private IDataRepository _dataRepository;

        public CarsService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            AllCars = _dataRepository.ReadAllCards();
            return AllCars;
        }

        public List<Car> GetCarsByMake(string make)
        {
            List<Car> foundCars = new List<Car>();
            if (AllCars.Count == 0)
                GetAllCars();
            foreach(Car c in AllCars)
            {
                if (c.Make.ToLower() == make.ToLower())
                    foundCars.Add(c);
            }
            return foundCars;
        }

        public List<Car> GetCarsByYear(int year)
        {
            List<Car> foundCars = new List<Car>();
            if (AllCars.Count == 0)
                GetAllCars();
            foreach (Car c in AllCars)
            {
                if (c.DateOfProduction.Year == year)
                    foundCars.Add(c);
            }
            return foundCars;
        }

        public void RemoveCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
