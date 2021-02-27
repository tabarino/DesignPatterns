using System;

namespace FlyweightExercise
{
    public class Cell
    {
        private readonly int _row;
        private readonly int _column;

        public string Content { private get; set; }
        public CellContext Context { get; set; }

        public Cell(int row, int column, CellContext context)
        {
            _row = row;
            _column = column;
            Context = context;
        }

        public void Render()
        {
            if (String.IsNullOrEmpty(Content))
            {
                Content = "Empty";
            }

            Console.WriteLine($"({_row}, {_column}): " +
                $"{Content} [{Context.FontFamily}] [{Context.FontSize}] [{Context.IsBold}]"
            );
        }
    }
}
