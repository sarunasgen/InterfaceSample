using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateOnly DateOfProduction { get; set; }
        public int EngineCapacity { get; set; }
        public int EnginePower { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} {DateOfProduction} {EngineCapacity}cm3 {EnginePower}kW";
        }

    }
}
