using CompanyLib;
namespace DemoLibrary
{
    [Serializable]
    [Car (Name="BMW", Price =1000)]
    public class Demo
    {
        public void sayhi()
        {
            Console.WriteLine("Hiii");
        }
    }
}
