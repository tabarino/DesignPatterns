using System;

namespace DecoratorExercise
{
    public class Artefact : AbstractArtefact
    {
        private readonly string _name;

        public Artefact(string name)
        {
            _name = name;
        }

        public string Render()
        {
            return _name;
        }
    }
}
