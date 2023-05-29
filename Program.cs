using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Area_and_Perimeter_of_Diff_Shapes_Using_Oops
{
    class Program
    {
        static void Main(string[] args)
        {

            int ShapeChoice,UserChoice;
            do
            {
               ///This gives us choice to select the options from the ShapeChoice menu.//
                
                Console.WriteLine("For what shape you want to calculate. \n1. Sqaure  \n2. Rectangle  \n3. Triangle  \n4. Circle \n0. Exit");
                Console.Write("Please Select the number from above options: ");
                ShapeChoice = int.Parse(Console.ReadLine());
                Shape SelectedShape = null;

                switch (ShapeChoice)
                {
                    case 1:
                        ///This takes input from the user for the square///
                        
                        double side = 0;
                        Console.Write("Enter the of side of square:  ");
                        side = double.Parse(Console.ReadLine());
                        
                        ///This creates object  for the Square///
                        
                        SelectedShape = new Square(side);
                        break;

                    case 2:

                        ///This takes input from the user for the rectangle///
                        
                        double length, width;
                        Console.Write("Please enter the length of rectangle: ");
                        length = double.Parse(Console.ReadLine());
                        Console.Write("Please enter the width of rectangle: ");
                        width = double.Parse(Console.ReadLine());

                        ///This creates object for the rectangle///
                        

                        SelectedShape = new Rectangle(length, width);
                        break;

                    case 3:
                        
                        ///This takes input from the user for the triangle///
                        
                        double height, baseoftriangle, side1, side2;
                        Console.Write("Please enter the height of triangle: ");
                        height = double.Parse(Console.ReadLine());
                        Console.Write("Please enter the base of triangle: ");
                        baseoftriangle = double.Parse(Console.ReadLine());
                        Console.Write("Please enter the side1 of triangle: ");
                        side1 = double.Parse(Console.ReadLine());
                        Console.Write("Please enter the side2 of triangle: ");
                        side2 = double.Parse(Console.ReadLine());
                        
                        ///This creates object for the triangle///
                        
                        SelectedShape = new Triangle(baseoftriangle, height, side1, side2);
                        break;

                    case 4:
                        
                        ///This takes input  from the user for the circle///
                        
                        double radius;
                        Console.Write("Please enter the radius of circle: ");
                        radius = double.Parse(Console.ReadLine());
                        Shape cir = new Circle(radius);

                        ///This creates object  for the circle///
                        
                        SelectedShape = new Circle(radius);
                        break;

                  case 0:
                        
                        Console.WriteLine("Exiting..");
                        break;

                    default:

                        Console.WriteLine("Invalid choice");
                        break;

                }
            
                if (SelectedShape != null)
                {
                    ///This calculationChoice gives us to select options to calculate and display the follwoing functions///
                    
                    int CalculationChoice;
                    do
                    {
                        Console.WriteLine("\n----------Select Calculation------------");
                        Console.WriteLine("\n1.Display Classname ");
                        Console.WriteLine("\n2.Calculate Area");
                        Console.WriteLine("\n3.Calculate Perimeter");
                        Console.WriteLine("\n4.Returning to UserChoice:");
                        Console.Write("\nEnter your choice:");
                        CalculationChoice = int.Parse(Console.ReadLine());


                        ///This switch case display the class name and Calulate Area & Perimeter of different shapes///
                        
                        switch (CalculationChoice)
                        {
                            case 1:
                                Console.WriteLine("Display Class name: " + SelectedShape.Display());
                                break;

                            case 2:
                                Console.WriteLine("Calculate Area: " + SelectedShape.CalculateArea());
                                break;

                            case 3:
                                Console.WriteLine("Calculate Perimeter: " + SelectedShape.CalculatePerimeter());
                                break;

                            case 4:
                                Console.WriteLine("Returning to Shape Selection... ");
                                break;
 
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }

                    ///This condition //
                    
                    while (CalculationChoice != 4 );
               
                }
               Console.WriteLine();
            }

            while (ShapeChoice != 0);
   
        }

       
    }
}






