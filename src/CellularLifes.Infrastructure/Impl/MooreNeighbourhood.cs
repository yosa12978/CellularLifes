using CellularLifes.Core.Domain;
using CellularLifes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Impl
{
    public class MooreNeighbourhood : INeighbourhood
    {
        public int CountNeighbours(Field field, Cell cell)
        {
            int count = 0;
            int[] dx = { -1, +1, 0, -1, +1, 0, -1, +1 };
            int[] dy = { 0, 0, -1, -1, -1, +1, +1, +1 };
            for (int i = 0; i < dx.Length; i++)
            {
                // Projective plane field (just a modulo operations (cell.x + dx[i])%field.Width and (cell.y + dy[i])%field.Height)
                int dxx = ( (cell.x + dx[i]) % field.Width + field.Width ) % field.Width;
                int dyy = ( (cell.y + dy[i]) % field.Height + field.Height ) % field.Height;
                if (//(cell.x + dx[i] < field.Width && cell.x + dx[i] > 0) &&
                    //(cell.y + dy[i] < field.Height && cell.y + dy[i] > 0) &&
                    (field.GameField[dxx, dyy] == 1))
                    count++;
            }
            return count;
        }
    }
}
