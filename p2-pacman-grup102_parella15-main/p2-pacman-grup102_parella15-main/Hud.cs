using System;

namespace Pacman
{
    public static class Hud
    {
        private static Position pos;
        private static int score;
        private static int init_time;

        // PENDENT IMPLEMENTAR SEGUIU EL DIAGRAMA UML
        static Hud()
        {
            pos = new Position(0, 25);
            score = -1;
        }

        public static void start()
        {
            Console.WriteLine("    Welcom To Programació I");
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("─██████████████─██████████████─██████████████─██████──────────██████─██████████████─██████──────────██████─");
            Console.WriteLine("─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░██████████──██░░██─");
            Console.WriteLine("─██░░██████░░██─██░░██████░░██─██░░██████████─██░░░░░░░░░░░░░░░░░░██─██░░██████░░██─██░░░░░░░░░░██──██░░██─");
            Console.WriteLine("─██░░██──██░░██─██░░██──██░░██─██░░██─────────██░░██████░░██████░░██─██░░██──██░░██─██░░██████░░██──██░░██─");
            Console.WriteLine("─██░░██████░░██─██░░██████░░██─██░░██─────────██░░██──██░░██──██░░██─██░░██████░░██─██░░██──██░░██──██░░██─");
            Console.WriteLine("─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██─────────██░░██──██░░██──██░░██─██░░░░░░░░░░██─██░░██──██░░██──██░░██─");
            Console.WriteLine("─██░░██████████─██░░██████░░██─██░░██─────────██░░██──██████──██░░██─██░░██████░░██─██░░██──██░░██──██░░██─");
            Console.WriteLine("─██░░██─────────██░░██──██░░██─██░░██─────────██░░██──────────██░░██─██░░██──██░░██─██░░██──██░░██████░░██─");
            Console.WriteLine("─██░░██─────────██░░██──██░░██─██░░██████████─██░░██──────────██░░██─██░░██──██░░██─██░░██──██░░░░░░░░░░██─");
            Console.WriteLine("─██░░██─────────██░░██──██░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░██──██░░██─██░░██──██████████░░██─");
            Console.WriteLine("─██████─────────██████──██████─██████████████─██████──────────██████─██████──██████─██████──────────██████─");
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────────────────────────────────────");


            Console.WriteLine("Pulsa una tecla...");
            if (Console.ReadKey() != null)
            {
                Console.Clear();
                init_time = Environment.TickCount;
            }
        }

        public static void updateScore()
        {
            score++;
        }

        public static void drawHud()
        {
            Console.SetCursorPosition(pos.col, pos.row);
            Console.Write("Score: " + score);

            Console.SetCursorPosition(pos.col, pos.row + 1);
            Console.Write("Temps: " + init_time * 1000);
        }

        public static void End(String missatge)
        {
            Console.SetCursorPosition(pos.col, pos.row + 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }

        //init_time = Environment.TickCount; // mil·lisegons

    }
}

