using InterfaceSample.Core.Contracts;
using InterfaceSample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Services
{
    public class MenuService
    {
        private readonly ICarsService _carsService;

        public MenuService(ICarsService carsService)
        {
            _carsService = carsService;
        }

        /// <summary>
        /// Shows menu white infinite loop
        /// </summary>
        public void ShowMenu()
        {

            while(true)
            {
                Console.WriteLine("1. Show all cars");
                Console.WriteLine("2. Find Cars by make");
                Console.WriteLine("3. Find Cars by year");
                Console.WriteLine("9. Quit");

                if(!int.TryParse(Console.ReadLine(), out int selection))
                {
                    Console.WriteLine("Bad input, try again");
                    continue;
                }
                switch(selection)
                {
                    case 1:
                        ShowCars(_carsService.GetAllCars());
                        break;
                    case 2:
                        Console.WriteLine("Enter make: ");
                        string make = Console.ReadLine();
                        ShowCars(_carsService.GetCarsByMake(make));
                        break;
                    case 3:
                        Console.WriteLine("Enter make: ");
                        int year = int.Parse(Console.ReadLine());
                        ShowCars(_carsService.GetCarsByYear(year));
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bad input, try again");
                        break;

                }
            }
        }
        private void ShowCars(List<Car> cars)
        {
            foreach(Car c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
