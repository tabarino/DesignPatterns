using System;
using System.Collections.Generic;

namespace DecoratorExercise
{
    public class Editor
    {
        public void OpenProject(string path)
        {
            var artefacts = new List<AbstractArtefact>() {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("Main"),
            };

            // We can apply multiple decorators
            artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            artefacts[2] = new ErrorDecorator(artefacts[2]);

            // In the future, we can create a SourceControlDecorator that adds
            // a special marker to the icon if artefacts are not committed to the repository.

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}
