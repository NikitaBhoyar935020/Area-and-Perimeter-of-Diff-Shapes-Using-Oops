using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    public class Triangle : Shape
    {
        private double height,baseoftriangle , side1 , side2;
        

        /// <summary>
        /// This is parameterized constructor having 4 paramters as well as pass the field to the object.
        /// </summary>
        /// <param name="baseoftriangle"></param>
        /// <param name="height"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>

        public Triangle(double baseoftriangle, double height, double side1, double side2)
        {
            
            this.baseoftriangle = baseoftriangle;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
       
        }

        public override string Display()
        {
            return GetType().Name;

        }

        /// <summary>
        /// This method calculates the area of Triangle.
        /// </summary>
        
        public override double CalculateArea()
        {
            return  (height * baseoftriangle) / 2;
        }

        /// <summary>
        /// This method calculates the perimeter of Triangle.
        /// </summary>
        
        public override double CalculatePerimeter()
        {
            return baseoftriangle + side1 + side2;
        }
    }
}
