// Write a class Distance containing Private Variable feet of tyoe int and inches of type int,
// suitable constructors and two methods addDistance and displayDistance objects.
// Write a separate class Program containing main methods to create and use distance objects
using System;
class Distance
{
    //private fields to store the feet and inches of the distance
    private int feet;
    private int inches;

    //default constructor to initialize the distance to 0
    public Distance()
    {
        feet = 0;
        inches = 0;
    }
    //constructors to initialize the distance with a given number of feet and inches
    public Distance(int feet, int inches)
    {
        this.feet = feet;
        this.inches = inches;
    }
    //method to addd two distance objects and return the result as a new distance object
    public Distance addDistance(Distance d1, Distance d2)
    {
        int totalFeet = d1.feet + d2.feet;
        int totalInches = d1.inches + d2.inches;

        //handle cases where the total number of inches exceed 12
        if (totalInches > 11)
        {
            totalFeet += totalInches / 12;
            totalInches %= 12;

        }
        return new Distance(totalFeet, totalInches);
    }
     // method to display the distance as string
     public string DisplayDistance()
    {
        return feet + "feet" + inches + "inches";
    }

}
class Program19
{
    static void Main()
    {
        //create two distance objects
        Distance d1 = new Distance(5, 7);
        Distance d2 = new Distance(8, 9);

        //add the distance and display the result
        Distance d3 = d1.addDistance(d1, d2);
        Console.WriteLine("Total distance:" + d3.DisplayDistance());
    }
}