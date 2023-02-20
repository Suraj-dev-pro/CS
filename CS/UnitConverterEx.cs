using System;
public class UnitConverter
{
    int ratio; 
    public UnitConverter(int unitRatio)
    {
        ratio = unitRatio;
    }
    public int Convert(int unit)
    {
        return unit * ratio;
    }
    class UnitConverterEx
    {
        static void Main()
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            
            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
        }
    }
}