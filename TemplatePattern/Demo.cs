using System;

namespace TemplatePattern
{
    public class Demo
    {
        public static void Show()
        {
            var task = new TransferMoneyTask();
            task.Execute();

            var newTask = new GenerateReportTask();
            newTask.Execute();
        }
    }
}
