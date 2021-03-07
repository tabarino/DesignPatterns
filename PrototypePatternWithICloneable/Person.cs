using System;
using System.Text;

namespace PrototypePatternWithICloneable
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }
        public Address Address { get; set; }

        public object ShallowClone()
        {
            return (Person)this.MemberwiseClone();
        }

        public object Clone()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = (IdInfo)this.IdInfo.Clone();
            other.Address = (Address)this.Address.Clone();
            other.Name = new StringBuilder(Name).ToString();

            return other;
        }
    }
}
