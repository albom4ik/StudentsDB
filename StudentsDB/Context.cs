using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB
{
    public class Context
    {
        private static Context _context;

        private Context() { }

        public Context Init() 
        {
            if (_context != null)
                _context = new Context();

            return _context;
        }
    }
}
