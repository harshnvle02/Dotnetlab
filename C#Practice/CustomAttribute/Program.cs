using System.Reflection;
using CompanyLib;
namespace CustomAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblypath = @"C:\Users\harsh\Desktop\Dot Net Practice\C#Practice\DemoLibrary\bin\Debug\net6.0\DemoLibrary.dll";
            Assembly asm = Assembly.LoadFrom(assemblypath);

            Type[] types = asm.GetTypes();

            for(int i=0; i<types.Length; i++)
            {
                Type t = types[i];

                Attribute[] attr = t.GetCustomAttributes().ToArray();

                for(int j=0; j<attr.Length; j++)
                {
                    Attribute a = attr[j];
                    if(a is Car)
                    {
                        Car c = a as Car;
                        Console.WriteLine("Type {0} is a {1} and has price {2}", c.Name,t.FullName, c.Price);
                    }
                }
            }
        }
    }
}
