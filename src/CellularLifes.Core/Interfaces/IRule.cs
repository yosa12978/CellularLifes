using CellularLifes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Interfaces
{
    public interface IRule
    {
        bool Check(Field field, Cell cell);
    }
}
