// Write a class Box with private variable width,
// height and depth and methods to find volume and surface area of two boxes
using System;

class Box
{
    //private fields to store dimensions of the box
    private float width;
    private float height;
    private float depth;

    //constructor to initialize the dimension of the box
    public Box(float width, float height, float depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
        //method to find the volume of the box
        public float findVolume()
        {
            return width * height * depth;
        }
        //method to find the surface area of the box
        public float findSurfaceArea()
        {
            return 2*(width * height * depth + height * depth);
        }
    
}
class Program18
{
    static void Main()
    {
        Box box1 = new Box(10, 20, 40);
        Box box2 = new Box(20, 80, 100);
        Console.WriteLine("Volume of box1: " + box1.findVolume());
        Console.WriteLine("Surface Area of box1: " + box1.findSurfaceArea());
        Console.WriteLine("Volume of box2: " + box2.findVolume());
        Console.WriteLine("Surface Area of box:" + box2.findSurfaceArea());
    }
}