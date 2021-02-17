using System;

namespace MediatorExercise
{
    public class UIControl
    {
        public event EventHandler SignupEventHandlers;

        protected void NotifyEventHandlers()
        {
            OnSignupEventHandlers();
        }

        protected virtual void OnSignupEventHandlers()
        {
            if (SignupEventHandlers != null)
            {
                SignupEventHandlers(this, EventArgs.Empty);
            }
        }
    }
}
