using System;

namespace DecoratorExercise
{
    public class MainDecorator : AbstractArtefact
    {
        private readonly AbstractArtefact _artefact;

        public MainDecorator(AbstractArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return $"{_artefact.Render()} [Main]";
        }
    }
}
