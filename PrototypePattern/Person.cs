using System;
using System.Text;

namespace PrototypePattern
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = new StringBuilder(Name).ToString();

            return other;
        }
    }
}
