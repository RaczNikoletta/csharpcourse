using System;
using System.Xml;


namespace RandomCrime
{
    class Program
    {
        
        static void Main(string[] args)
        {
            XmlTextReader text = new XmlTextReader("crime.xml");
            text.Read();

            while (text.Read())
            {

                text.MoveToElement();
                Console.WriteLine("Type: " + text.Name);
                Console.WriteLine("Base URI:" + text.BaseURI);
                Console.WriteLine("Local Name:" + text.LocalName);
                Console.WriteLine("Attribute Count:" + text.AttributeCount.ToString());
                Console.WriteLine("Depth:" + text.Depth.ToString());
                Console.WriteLine("Line Number:" + text.LineNumber.ToString());
                Console.WriteLine("Node Type:" + text.NodeType.ToString());
                Console.WriteLine("Attribute Count:" + text.Value.ToString());

            }




        }



        public class Crime
        {
            public string type;
            public int year;
            public int month;
            public int hour;
            public int minute;
            public string block;
            public string neighbourhood;
            public double xCoor;
            public double yCoor;
            public double latitude;
            public double longitude;
        }
    }
}
