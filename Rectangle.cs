using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    public class Rectangle : Shape
    {
        private double length, width;
        
       
        /// <summary>
        /// This is parameterized constructor having 2 parameter as well as its passess the field to the object.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>\
        public Rectangle(double length , double width)
        {
            this.length = length;
            this.width = width;
           
        }

        public override string Display()
        {
            return GetType().Name;

        }

        /// <summary>
        /// This method calculates the area of Rectangle.
        /// </summary>
      
        public override double CalculateArea()
        {
            return length * width;
        }


        /// <summary>
        /// This method calculate the perimeter of Rectangle.
        /// </summary>
        
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
