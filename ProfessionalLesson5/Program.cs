//Завдання 2

//Створіть програму, яка виводить на екран всю інформацію про вказаний .xml файл.
using System.Xml;

namespace ProfessionalLesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream streamXml = new FileStream("test.xml",FileMode.Open);
            XmlTextReader xmlTextReader = new XmlTextReader(streamXml);

            while(xmlTextReader.Read() )
            {
                Console.WriteLine(xmlTextReader.ReadInnerXml());
            }
        }
    }
}