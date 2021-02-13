using System;
using CommandPattern.Fx;

namespace CommandPattern
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}
