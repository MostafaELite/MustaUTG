using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace UnitTestGenerator.Application
{
    public static class Extensions
    {
        public static Control Where(this ControlCollection controlCollection, Predicate<Control>  predicate)
        {
            foreach (Control control in controlCollection)
                if (predicate(control))
                    return control;
            return null;
        }
    }
}
