using System;
using AdapterPattern.AvaFilters;

namespace AdapterPattern
{
    public class CaramelAdapterUsingInheritance : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            base.Init();
            base.Render(image);
        }
    }
}
