using System;

namespace FlyweightExercise
{
    public class SpreadSheet
    {
        private const int MAX_ROWS = 3;
        private const int MAX_COLS = 3;

        private Cell[,] _cells = new Cell[MAX_ROWS, MAX_COLS];
        private CellContextFactory _contextFactory;

        public SpreadSheet(CellContextFactory contextFactory)
        {
            _contextFactory = contextFactory;

            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            if (!EnsureCellExists(row, col))
            {
                Console.WriteLine("Cell Does Not Exist");
                return;
            }

            _cells[row, col].Content = content;
        }

        // We could have a similar method font setting the fontSize or isBold
        // for a given cell. I've omitted that here.
        public void SetFontFamily(int row, int col, string fontFamily)
        {
            if (!EnsureCellExists(row, col))
            {
                Console.WriteLine("Cell Does Not Exist");
                return;
            }

            var cell = _cells[row, col];
            var currentContext = cell.Context;
            var context = _contextFactory.GetContext(fontFamily, currentContext.FontSize, currentContext.IsBold);
            _cells[row, col].Context = context;
        }

        private bool EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
            {
                Console.WriteLine("Row Does Not Exist");
                return false;
            }

            if (col < 0 || col >= MAX_COLS)
            {
                Console.WriteLine("Column Does Not Exist");
                return false;
            }

            return true;
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
            {
                for (var col = 0; col < MAX_COLS; col++)
                {
                    _cells[row, col] = new Cell(row, col, GetDefaultContext());
                }
            }
        }

        private CellContext GetDefaultContext()
        {
            // In a real app, these values should not be hardcoded here.
            // They should be read from a configuration file.
            return new CellContext("Times New Roman", 12, false);
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
            {
                for (var col = 0; col < MAX_COLS; col++)
                {
                    _cells[row, col].Render();
                }
            }
        }
    }
}
