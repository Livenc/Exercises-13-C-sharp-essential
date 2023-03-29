namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.SetWindowSize(100, 100);
            ////Console.WriteLine("2313");
            ////Console.ReadKey();
            ///public static void Main()
            {
                int origWidth, width;
                int origHeight, height;
                //string m1 = "The current window width is {0}, and the " +
                //            "current window height is {1}.";
                //string m2 = "The new window width is {0}, and the new " +
                //            "window height is {1}.";
                //string m4 = "  (Press any key to continue...)";
                ////
                //// Step 1: Get the current window dimensions.
                ////
                //origWidth = Console.WindowWidth;
                //origHeight = Console.WindowHeight;
                //Console.WriteLine(m1, Console.WindowWidth,
                //                      Console.WindowHeight);
                //Console.WriteLine(m4);
                //Console.ReadKey(true);
                ////
                //// Step 2: Cut the window to 1/4 its original size.
                ////
                width = 100;
                height = 40;
                Console.SetWindowSize(100, 40);
                for (int i = 0; i < 40; i++)
                {
                    WriteAt("k",0,i);
                    Thread.Sleep(500);
                    WriteAt(" ",0,i);
                }
                //Console.WriteLine( Console.WindowWidth+ " " +
                //                      Console.WindowHeight);
                
                //Console.ReadKey(true);
                ////
                //// Step 3: Restore the window to its original size.
                ////
           
                Console.ReadKey();
            }
            static void TextDown()
            {
                Random random = new Random();

                int dlina = random.Next(1,5);

            }
             static void WriteAt(string s, int x, int y)
            {
                try
                {
                    Console.SetCursorPosition( x,  y);
                    Console.Write(s);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}