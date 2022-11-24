using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Xml;

namespace WOPR_Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Color screenTextColor = Color.FromArgb(100, 205, 250);
            Color screenBackgroundColor = Color.Black;
            Console.Title = "WOPR Systems";
            int irc = SetScreenColorsApp.SetScreenColors(screenTextColor, screenBackgroundColor);



            Toolbox.TitleCard();
            Toolbox.DialingNumbers();
            Toolbox.ListingNumbers();




            Console.Write("\n\n\nPROGRAM HAS ENDED OPERATION, THERE IS NO METHOD OR LINE LEFT TO CALL.\nPress ENTER to exit...");
            Console.ReadKey();
        }

        public static void TypeOut(string text, int delayMS, bool playsound = false, bool startNewLine = true)
        {
            SoundPlayer typingsound = new SoundPlayer("./Assets/Sounds/computer text whirr.wav");

            if (startNewLine)
            {
                Console.Write("\n");
            }

            if (playsound == true)
            {
                typingsound.PlayLooping();
                Task.WaitAll(Task.Delay(70));
            }
            foreach (char c in text)
            {
                
                Task.WaitAll(Task.Delay(delayMS));
                Console.Write(c);
            }
            if (playsound == true)
            {
                typingsound.Stop();
            }
        }

        public static void CenterType(string s, bool startNewLine = true)
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            
            if (startNewLine == true)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.Write(s);
            }
        }

        public static void SetColors(Color foregroundC, Color? backgroundC = null)
        {
            if(backgroundC == null)
            {
                SetScreenColorsApp.SetScreenColors(foregroundC, Color.Black);
            }
            else
            {
                Color backgroundC1 = backgroundC.Value;
                SetScreenColorsApp.SetScreenColors(foregroundC, backgroundC1);
            }
        }
    }
}