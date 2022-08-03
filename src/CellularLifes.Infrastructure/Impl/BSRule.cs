using CellularLifes.Core.Domain;
using CellularLifes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Impl
{
    public class BSRule : IRule
    {
        private int[] born { get; set; } = default!;
        private int[] surv { get; set; } = default!;
        private INeighbourhood nhood { get; set; } = default!;
        public int[] Born 
        { 
            get { return born; } 
            set { born = value; } 
        }
        public int[] Surv
        {
            get { return surv; }
            set { surv = value; }
        }
        public INeighbourhood Neighbourhood
        {
            get { return nhood; }
            set { nhood = value; }
        }
        public bool Check(Field field, Cell cell)
        {
            int neighbours = nhood.CountNeighbours(field, cell);
            return ((field.GameField[cell.x, cell.y] == 0 && born.Contains(neighbours)) ||
                (field.GameField[cell.x, cell.y] == 1 && surv.Contains(neighbours)));
        }
    }
}
