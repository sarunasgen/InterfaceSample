using InterfaceSample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample.Core.Contracts
{
    public interface IDataRepository
    {
        List<Car> ReadAllCards();
        void WriteCars(List<Car> cars);
    }
}
