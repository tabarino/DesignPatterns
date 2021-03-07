using System;
using System.Text;

namespace PrototypePatternWithICloneable
{
    public class IdInfo : ICloneable
    {
        public int IdNumber { get; set; }

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
