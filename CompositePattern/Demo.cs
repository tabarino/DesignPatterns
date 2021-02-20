using System;

namespace CompositePattern
{
    public class Demo
    {
        public static void Show()
        {
            // Imaginary Squares
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            // Imaginaty Circles
            var group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());

            var group = new Group();
            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();
        }
    }
}
