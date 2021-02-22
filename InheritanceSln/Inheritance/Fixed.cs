using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fixed : Account
    {
        private int tenureYear;
        public int TenureYear
        {
            set { tenureYear = value; }
            get { return tenureYear; }
        }
        public Fixed()
        {
            Console.WriteLine("Fixed Created with default");
        }
        public Fixed(int tenureYear)
        {
            this.tenureYear = tenureYear;
            Console.WriteLine("Fixed Created with 1 parameter");
        }
    }
}
