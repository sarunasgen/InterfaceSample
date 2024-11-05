using InterfaceSample.Core.Contracts;
using InterfaceSample.Core.Repositories;
using InterfaceSample.Core.Services;
using System;

namespace InterfaceSample;

public class Program
{
    public static void Main(string[] args)
    {
        string csvFileLocation = "carsSheet.csv";
        IDataRepository csvRepository = new CSVFileRepository(csvFileLocation);
        ICarsService carsService = new CarsService(csvRepository);
        MenuService menuService = new MenuService(carsService);
        menuService.ShowMenu();
    }
}
