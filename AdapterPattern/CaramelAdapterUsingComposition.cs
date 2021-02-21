using System;
using AdapterPattern.AvaFilters;

namespace AdapterPattern
{
    public class CaramelAdapterUsingComposition : IFilter
    {
        private readonly Caramel _caramel;

        public CaramelAdapterUsingComposition(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}
