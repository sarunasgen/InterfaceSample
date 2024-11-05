using InterfaceSample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Contracts
{
    public interface ICarsService
    {
        /// <summary>
        /// By given in the constructor file location, reads and returns all the cars from file
        /// </summary>
        /// <returns>All cars from given file</returns>
        List<Car> GetAllCars();
        void AddCar(Car car);
        void RemoveCar(Car car);
        /// <summary>
        /// Finds all cars that match given make
        /// </summary>
        /// <param name="make">Make to match</param>
        /// <returns>Found cars matching the criteria</returns>
        List<Car> GetCarsByMake(string make);
        List<Car> GetCarsByYear(int year);
        void Save();
    }
}
