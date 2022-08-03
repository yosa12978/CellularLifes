using CellularLifes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Interfaces
{
    public interface INeighbourhood
    {
        int CountNeighbours(Field field, Cell cell);
    }
}
