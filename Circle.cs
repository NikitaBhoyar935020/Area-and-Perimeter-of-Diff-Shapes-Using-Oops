using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    public class Circle : Shape
    {
        private double radius;
        
        /// <summary>
        /// This is parameterized constructor having one paramemter as well as its pass the field to the object.
        /// </summary>
        /// <param name="radius"></param

        public Circle(double radius)
        {
            this.radius = radius;
            
        }

        public override string Display()
        {
            return GetType().Name;

        }

        /// <summary>
        /// This method calculate the area of circle.
        /// </summary>
   
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }


        /// <summary>
        /// This method calculates the perimeter of circle.
        /// </summary>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
