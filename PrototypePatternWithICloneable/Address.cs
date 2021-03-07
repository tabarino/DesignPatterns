using System;
using System.Text;

namespace PrototypePatternWithICloneable
{
    public class Address : ICloneable
    {
        public string Street { get; set; }
        public string PostCode { get; set; }

        public Address(string street, string postCode)
        {
            Street = street;
            PostCode = postCode;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
