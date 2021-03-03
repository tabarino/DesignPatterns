using System;

namespace BuilderPattern
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        public IBuilder Builder { private get; set; }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            Builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            Builder.BuildPartA();
            Builder.BuildPartB();
            Builder.BuildPartC();
        }
    }
}
