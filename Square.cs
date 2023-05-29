using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    public class Square : Shape
    {
        private double side;
        
        /// <summary>
        /// This is parameterized constructor having one parameter which pass field to the object.
        /// </summary>
        /// <param name="side"></param>

        public Square(double side)
        {
            this.side = side;
          
        }
    
        public override string Display()
        {
            return GetType().Name;

        }

        /// <summary>
        /// This method is used to calculate the Area of Square.
        /// </summary>
        /// <returns>
       
        public override double CalculateArea()
        {
            return side * side;
            
        }

        /// <summary>
        /// This method is used to calculate the Perimeter of Square.
        /// </summary>
       
        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
          
    }
}
