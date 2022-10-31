using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_objects
{
    public class Map
    {
        private static List<List<int>> _grid = new();
        public static List<int> _rows = new();
        private static List<int> _columns = new();

        public Map(int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                _rows.Add(i);
                _columns.Add(i);
            }

            _grid.Add(_rows);
            _grid.Add(_columns);
           
        }
    }
}
