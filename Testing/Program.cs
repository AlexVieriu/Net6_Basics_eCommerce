using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {       
            foreach (var item in (EnumNames[])Enum.GetValues(typeof(EnumNames)))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    public enum EnumNames
    {
        Alex, 
        Dumi, 
        Cristi
    }
}
