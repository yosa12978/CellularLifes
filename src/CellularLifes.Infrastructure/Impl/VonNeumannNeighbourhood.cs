using CellularLifes.Core.Domain;
using CellularLifes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Impl
{
    public class VonNeumannNeighbourhood : INeighbourhood
    {
        public int CountNeighbours(Field field, Cell cell)
        {
            int count = 0;
            int[] dx = { +1, -1, 0, 0 };
            int[] dy = { 0, 0, +1, -1 };
            for (int i = 0; i < 4; i++)
                if ((cell.x + dx[i] < field.Width && cell.x + dx[i] > 0) &&
                    (cell.y + dy[i] < field.Height && cell.y + dy[i] > 0) &&
                    (field.GameField[cell.x + dx[i],cell.y + dy[i]] == 1))
                    count++;
            return count;
        }
    }
}
