using System;

namespace DecoratorExercise
{
    public class ErrorDecorator : AbstractArtefact
    {
        private readonly AbstractArtefact _artefact;

        public ErrorDecorator(AbstractArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            var mainIcon = _artefact.Render();
            return $"{mainIcon} [Error]";
        }
    }
}
