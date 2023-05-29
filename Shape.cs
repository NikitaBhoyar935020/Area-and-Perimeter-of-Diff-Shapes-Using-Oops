using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    public abstract class Shape
    { 

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public virtual string Display()
        {
            return GetType().Name;
        }
    }
}
