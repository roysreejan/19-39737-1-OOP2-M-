using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class OverDraft : Account
    {
        private int limit;
        public int Limit
        {
            set { limit = value; }
            get { return limit; }
        }
        public OverDraft()
        {
            Console.WriteLine("OverDraft Created with default");
        }
        public OverDraft(int limit)
        {
            this.limit = limit;
            Console.WriteLine("OverDraft Created with 1 parameter");
        }
    }
}
