using System.Reflection;
using System.Reflection.Metadata;

namespace MyAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblypath = @"C:\Users\harsh\Desktop\Dot Net Practice\C#Practice\Cmath\bin\Debug\net6.0\Cmath.dll";
            Assembly asm = Assembly.LoadFrom(assemblypath);

            Type[] types = asm.GetTypes();
            string str = null;

            for (int i = 0; i < types.Length; i++)
            {
                Type t = types[i];
                object dynamicallyCreatedObject = asm.CreateInstance(t.FullName);

                MethodInfo[] method = t.GetMethods();
                for (int j = 0; j < method.Length; j++)
                {
                    MethodInfo m = method[j];
                    str = m.ReturnType + " " + m.Name + "(";

                    ParameterInfo[] allParam = m.GetParameters();
                    object[] inputParam = new object[allParam.Length];
                    for (int k = 0; k < allParam.Length; k++)
                    {
                        ParameterInfo p = allParam[k];
                        str = str + p.ParameterType.ToString() + " " + p.Name + ",";
                    }
                    for (int l = 0; l < inputParam.Length; l++)
                    {
                        Console.WriteLine("Enter value of {0} of type {1}", allParam[l].Name, allParam[l].ParameterType);
                        object val = Convert.ChangeType(Console.ReadLine(), allParam[l].ParameterType);
                        inputParam[l] = val;
                    }
                    str = str.TrimEnd(',')+')';
                    Console.WriteLine(str);
                    
                    object? result = t.InvokeMember(m.Name,
                                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                                    null,
                                    dynamicallyCreatedObject,
                                    inputParam);
                    Console.WriteLine("Result of {0} = {1}", m.Name, result);
                }
            }
        }
    }
}
