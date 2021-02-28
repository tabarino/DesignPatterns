using System;

namespace ProxyExercise
{
    public class ProductProxy : Product
    {
        private DbContext _context;

        public new string Name
        {
            set
            {
                base.Name = value;
                _context.MarkAsChanged(this);
            }
        }

        public ProductProxy(int id, DbContext context) : base(id)
        {
            _context = context;
        }
    }
}
