//Завдання 3

//З файлу TelephoneBook.xml (файл повинен був бути створений у процесі виконання додаткового завдання) виведіть на екран лише номери телефонів.
using System.Xml.Linq;
namespace ProfessionalEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("TelephoneBook.xml");

            XElement elements = document.Root;

            var phoneNumbers =
                from element in elements.Elements()
                where element.Name == "Contact"
                select element;
            foreach(var phoneNumber in phoneNumbers )
            {
                Console.WriteLine($"{phoneNumber.Value} = {phoneNumber.FirstAttribute.Value}");
            }
        }
    }
}