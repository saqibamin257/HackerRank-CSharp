using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank
{
    internal class ReadXML
    {
        public static void ReadXMLNode() 
        {
            XDocument doc = XDocument.Load(@"D:\WTH8XO.xml");
            XNamespace ns = "http://www.w3.org/2001/XMLSchema";
            var status = doc.Descendants(ns + "FolderCreateResponse").Select(e => e.Element(ns + "StatusNotes"));
            var attributes = doc.Descendants("StatusNotes");
            foreach (var attribute in attributes)
            {
                if (attribute.Name == "StatusNotes")
                {
                    Console.WriteLine(attribute.Value);
                    break;
                }
            }
        }
    }
}
