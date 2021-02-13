using System;

namespace TemplatePattern
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}
