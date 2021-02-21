using System;
using AdapterPattern.AvaFilters;

namespace AdapterPattern
{
    public class Demo
    {
        public static void Show()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());

            // Adapter Pattern using Composition
            imageView.Apply(new CaramelAdapterUsingComposition(new Caramel()));

            // Adapter Pattern using Inheritance
            imageView.Apply(new CaramelAdapterUsingInheritance());

            // NOTE: FAVOR COMPOSITION OVER INHERITANCE
        }
    }
}
