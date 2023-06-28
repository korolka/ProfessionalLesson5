using Microsoft.Win32;

namespace AdminProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                RegistryKey key = Registry.CurrentUser;

                key = key.CreateSubKey(@"Software\Vlad\Set");

                key.SetValue("Text", "default text");
                key.SetValue("Color", ConsoleColor.Green);
                key.SetValue("WindowSize", new byte[2] {80,90});

                Console.WriteLine("Value saved sucsessful");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}