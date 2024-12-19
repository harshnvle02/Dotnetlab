using System.Collections;
using System.Security.AccessControl;
using System.Text.Json;
using System.Xml.Serialization;

namespace IOFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;

            string filepath = @"C:\Users\harsh\Desktop\Dot Net Practice\demo.xml";



            #region Write Data
            // if(File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            //}
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Enter something");
            //string inputString = Console.ReadLine();
            //writer.WriteLine(inputString);
            //writer.Close();
            //fs.Close();

            //Console.WriteLine("Done");
            #endregion

            #region Read

            //if(File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //StreamReader reader = new StreamReader(fs);
            //String readLine = reader.ReadToEnd();

            //Console.WriteLine(readLine);
            #endregion

            #region Json Serializer

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Read);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            //}
            //Product p = new Product();
            //p.Id = 1;
            //p.Name = "Laptop";
            //p.Price = 1000;
            //StreamWriter writer = new StreamWriter(fs);

            //JsonSerializer.Serialize(fs, p);
            //writer.WriteLine(p);
            //writer.Flush();
            //writer.Close();

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //Product  p = JsonSerializer.Deserialize<Product>(fs);
            //Console.WriteLine($"ID : {p.Id}, Name : {p.Name}, Price : {p.Price}");
            //fs.Close();
            #endregion

            #region XmlSerializer
            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            Product p = new Product();
            p.Id = 1;
            p.Name = "Laptop";
            p.Price = 1000;

            Book book = new Book();
            book.Id = 2;
            book.Bname = "Test";
            ArrayList arr= new ArrayList();
            arr.Add(p);
            arr.Add(book);

            Type[] types = new Type[arr.Count];
            types[0] = typeof(Product);
            types[1] = typeof(Book);

            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList),types);
            serializer.Serialize(fs,arr);
            #endregion
        }
    }
    class Product
    {
        private int _pid;
        private string _pname;
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public string Name
        {
            get { return _pname; }
            set { _pname = value; }
        }


        public int Id
        {
            get { return _pid; }
            set { _pid = value; }
        }

    }
    class Book
    {
        private int _id;
        private string _bname;

        public string Bname
        {
            get { return _bname; }
            set { _bname = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
