using System;

namespace FlyweightExercise
{
    public class Demo
    {
        public static void Show()
        {
            var contextFactory = new CellContextFactory();
            var sheet = new SpreadSheet(contextFactory);
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            sheet.Render();
        }
    }
}
