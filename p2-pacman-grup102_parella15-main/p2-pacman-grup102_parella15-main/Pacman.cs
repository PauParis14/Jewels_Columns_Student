using System;

namespace Pacman
{
    public class Pacman
    {
        private char C_PACMAN = '@';
        private Position pos;

        // PENDENT IMPLEMENTAR SEGUIU EL DIAGRAMA UML

        public Pacman(int N)
        {
            C_PACMAN = '@';
            pos = new Position(N, N);
        }

        public Position setPosition(ConsoleKeyInfo userInput)
        {
            Position posicio = pos;
            switch (userInput.Key)
            {
                case ConsoleKey.LeftArrow:
                    posicio.col--;
                    break;
                case ConsoleKey.RightArrow:
                    posicio.col++;
                    break;
                case ConsoleKey.UpArrow:
                    posicio.row--;
                    break;
                case ConsoleKey.DownArrow:
                    posicio.row++;
                    break;
            }
            return posicio;
        }

        public void setPosition(Position new_pos)
        {
            pos = new_pos;
        }

        public Position getPosition()
        {
            return pos;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(pos.col, pos.row);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(C_PACMAN);
            Console.ResetColor();
        }
    }
}
