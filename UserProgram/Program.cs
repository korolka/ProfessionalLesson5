using Microsoft.Win32;
using System.Drawing;

namespace UserProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Color color1;
            byte[] windowSize;
            try
            {
                RegistryKey key = Registry.CurrentUser;
                key = key.OpenSubKey(@"Software\Vlad\Set");

                text = key.GetValue("Text") as string;
                string color = key.GetValue("Color") as string;
                windowSize = (byte[])key.GetValue("WindowSize");

                Console.SetWindowSize(windowSize[0], windowSize[1]);

                Color colors = Color.FromName(color);
                ConsoleColor color2 = Enum.Parse<ConsoleColor>(color);
                Console.ForegroundColor = color2;

                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}