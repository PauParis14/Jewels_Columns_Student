using System;

namespace Pacman
{
    public class Fantasma
    {
        private char C_FANTASMA = '&';
        private ConsoleColor color;
        private Position pos;
        // PENDENT IMPLEMENTAR SEGUIU EL DIAGRAMA UML
        public Fantasma(int x, int y, ConsoleColor color)
        {
            pos = new Position(x, y);
            this.color = color;
        }

        public String move(Position pacman, Taulell t)
        {
            Position posicio = pos;
            if (pos.row < pacman.row)
            {
                posicio.row++;
            }
            else if (pos.row > pacman.row)
            {
                posicio.row--;
            }
            else if (pos.col < pacman.col)
            {
                posicio.col++;
            }
            else if (pos.col > pacman.col)
            {
                posicio.col--;
            }

            if (t.checkPosition(posicio))
            {
                pos = posicio;
            }

            if (pos.row == pacman.row && pos.col == pacman.col)
            {
                return "Has perdut!";
            }
            return null;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(pos.col, pos.row);
            Console.ForegroundColor = color;
            Console.Write(C_FANTASMA);
            Console.ResetColor();
        }
    }
}