﻿using System;

namespace Pacman
{
    public class Taulell
    {
        private const int N = 20;
        private char[,] taulell;

        public Taulell()
        {
            taulell = new char[N, N]{
{   '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    ' ',    '#',    '.',    '#',    '.',    '#',    ' ',    '#',    '.',    '#',    ' ',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '#',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '#',    '#',    '.',    '#',    '#',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#',    ' ',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    ' ',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    ' ',    '#',    '.',    '#',    '.',    '#',    ' ',    '#',    '.',    '#',    ' ',    '#',    '.',    '#'},
{   '#',    '.',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '.',    '#',    '#',    '#',    '.',    '#',    '#',    '#',    '.',    '#'},
{   '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '.',    '#'},
{   '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#',    '#'}};


        }
        public int getDimension() { return N; }

        // PENDENT IMPLEMENTAR SEGUIU EL DIAGRAMA UML
        public void mostrar()
        {
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    if (taulell[i, j] == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                    else if (taulell[i, j] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                    Console.Write(taulell[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

        }

        public bool checkPosition(Position new_pos)
        {
            if (taulell[new_pos.col, new_pos.row] != '#')
            {
                return true;
            }
            return false;
        }

        public void PacmanPosition(Position new_pos)
        {
            if (taulell[new_pos.col, new_pos.row] == '.')
            {
                taulell[new_pos.col, new_pos.row] = ' ';
                Hud.updateScore();
            }
        }

        public String guanyat()
        {
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    if (taulell[i, j] == '.')
                    {
                        return null;
                    }
                }
            }
            return "Has guanyat!";
        }
    }
}
