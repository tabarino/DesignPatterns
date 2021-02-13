using System;

namespace TemplatePattern
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
