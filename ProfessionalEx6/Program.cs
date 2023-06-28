//Завдання 6

//Створіть.xml файл, який би відповідав наступним вимогам:

//• ім 'я файлу: TelephoneBook.xml

//• кореневий елемент: “MyContacts”

//• тег “Contact”, і в ньому має бути записано ім'я контакту та атрибут “TelephoneNumber” зі значенням номера телефону.
using System.Text;
using System.Xml;

namespace ProfessionalEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("TelephoneBook.xml", FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(file, null);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("MyContacts");
            writer.WriteStartElement("Contact");
            writer.WriteStartAttribute("TelephoneNumber");
            writer.WriteString("380662567143");
            writer.WriteEndAttribute();
            writer.WriteString("Vlad");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.Close();
            file.Close();

        }
    }
}