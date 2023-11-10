using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3._0.clases
{
    internal class ClaseDivision
    {
        public double clasedivision(double n1, double n2)
        {
            double Rdivision = 0;
            try
            {
                if (n1 != 0 && n2 != 0)
                    Rdivision = n1 / n2;
                else
                    Rdivision = -1;

                return Rdivision;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); return 0; }
        }
    }
}
