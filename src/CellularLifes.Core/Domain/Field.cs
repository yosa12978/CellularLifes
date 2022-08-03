using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularLifes.Core.Domain
{
    public class Field
    {
        private int[,] field { get; set; } = default!;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int[,] GameField 
        { 
            get 
            { 
                return field;
            }
            set 
            {
                Width = value.GetLength(0);
                Height = value.GetLength(1);
                field = value;
            }
        }
        public Field (int width, int height)
        {
            this.GameField = new int[width, height];
        }


    }
}
