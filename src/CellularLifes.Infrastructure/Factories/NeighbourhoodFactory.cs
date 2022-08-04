using CellularLifes.Core.Impl;
using CellularLifes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Infrastructure.Factories
{
    public interface INeighbourhoodFactory
    {
        INeighbourhood CreateMooreNH();
        INeighbourhood CreateVonNeumannNH();
    }
    public class NeighbourhoodFactory : INeighbourhoodFactory
    {
        public INeighbourhood CreateMooreNH() => 
            new MooreNeighbourhood();

        public INeighbourhood CreateVonNeumannNH() =>
            new VonNeumannNeighbourhood();
    }
}
