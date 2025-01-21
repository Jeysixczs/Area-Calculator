using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator
{
    internal class Calculator
    {
        public double CalculateArea(double lengths, double widths)
        {

            return lengths * widths;
        }

        public double CalculateArea(double radiuss)
        {

            return Math.PI * (radiuss * radiuss);
        }


        public double CalculateArea(double bases, double heights, bool isTriangle)
        {
            if (isTriangle)
            {

                return 0.5 * (bases * heights);

            }
            else
            {
                return bases * heights;
            }

        }
    }
}
