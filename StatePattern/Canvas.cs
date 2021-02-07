using System;

namespace StatePattern
{
    public class Canvas
    {
        private Tool _currentTool;
        public Tool CurrentTool { get => _currentTool; set => _currentTool = value; }

        public void MouseDown()
        {
            _currentTool.MouseDown();
        }

        public void MouseUp()
        {
            _currentTool.MouseUp();
        }
    }
}
