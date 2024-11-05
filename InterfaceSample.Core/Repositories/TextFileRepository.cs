using InterfaceSample.Core.Contracts;
using InterfaceSample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Repositories
{
    public class TextFileRepository : IDataRepository
    {
        private readonly string _fileLocation;

        public TextFileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
            if(!_fileLocation.Contains(".txt"))
            {
                throw new Exception("Wrong file format. Expected: .txt");
            }

        }

        public List<Car> ReadAllCards()
        {
            List<Car> allCars = new List<Car>();
            using(StreamReader sr = new StreamReader(_fileLocation))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');
                    Car newCar = new Car
                    {
                        Make = values[0],
                        Model = values[1],
                        DateOfProduction = DateOnly.Parse(values[2]),
                        EngineCapacity = int.Parse(values[3]),
                        EnginePower = int.Parse(values[4])
                    };
                    allCars.Add(newCar);
                } 
            }
            return allCars;
        }

        public void WriteCars(List<Car> cars)
        {
            throw new NotImplementedException();
        }
    }
}
