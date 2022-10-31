using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_objects
{
    public class Grid
    {
        public List<List<int>> _grid = new();
        private List<int> _rows = new();
        private List<int> _columns = new();

        public void CreateGrid(int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                _rows.Add(i);
                _columns.Add(i);
            }

            _grid.Add(_rows);
            _grid.Add(_columns);

            foreach (var item in _grid)
            {
                Console.WriteLine(_grid[0].Count());
            }
        }
    }
}
