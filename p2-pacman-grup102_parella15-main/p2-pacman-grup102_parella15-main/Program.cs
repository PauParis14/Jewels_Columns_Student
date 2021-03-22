using System;
using System.Collections.Generic;
using System.Threading;

namespace Pacman
{

    class Program
    {

        // PENDENT IMPLEMENTAR : 
        // defineix una llista de fantasmas
        public static List<Fantasma> myFantasmicos;
        // defineix un objecte de la classe Taulell
        public static Taulell myTaulell;
        // defineix un objecte de la classe Pacman
        public static Pacman thePacman;


        static void Main()
        {
            Console.WriteLine("Hello World!");
            String s = null;

            init();
            // PENDENT IMPLEMENTAR : crida el mètode start de la classe Hud
            Hud.start();

            mostrar();

            while (s == null)
            {
                s = update();
                mostrar();
                Thread.Sleep(700);//miliseconds
            }

            // PENDENT IMPLEMENTAR : crida el mètode End de la classe Hud
            Hud.End("Has perdut!");

        }
        private static void init()
        {
            // PENDENT IMPLEMENTAR :
            // inicialitza tots els atributs

            // l'objecte myTaulell de la classe Taulell
            myTaulell = new Taulell();
            // l'objecte thePacman de la classe Pacman
            thePacman = new Pacman(9);
            // crida el mètode PacmanPosition de l'objecte myTaulell per menjar la primera galeta
            myTaulell.PacmanPosition(new Position(9, 9));
            // inicialitza la llista dels fantasmes amb 4 objectes, cadascú a una cantonada del laberint i en un color diferent
            myFantasmicos = new List<Fantasma>()
            {
                new Fantasma(1,1, ConsoleColor.Red),
                new Fantasma(1,18, ConsoleColor.DarkYellow),
                new Fantasma(18,18, ConsoleColor.Cyan),
                new Fantasma(18,1, ConsoleColor.Magenta)
            };

        }

        private static String update()
        {

            if (Console.KeyAvailable)
            {
                // PENDENT IMPLEMENTAR :
                // moure el pacman a partir de l'entrada de l'usuari
                // utiliza els mètodes setPosition de la classe pacman
                // i els mètodes checkPosition i PacmanPosition de la classe Taulell
                Position posicio = thePacman.setPosition(Console.ReadKey());
                if (myTaulell.checkPosition(posicio))
                {
                    myTaulell.PacmanPosition(posicio);
                    thePacman.setPosition(posicio);
                }
            }


            // PENDENT IMPLEMENTAR :
            // moure tots els fantasmes de la llista
            // si un fantasma atrapa al pacman retorna el missatge


            // PENDENT IMPLEMENTAR :
            // si pacman guanya la partida retorna el missatge
            return null;
        }
        private static void mostrar()
        {
            Console.Clear();
            // PENDENT IMPLEMENTAR :
            // primer mostra el taulell
            myTaulell.mostrar();
            // després els fantasmes i el pacman
            foreach (var fantasma in myFantasmicos)
            {
                fantasma.Mostrar();
            }
            thePacman.Mostrar();
            // per últim el Hud
            Hud.drawHud();
            Console.SetCursorPosition(10, 25);
            Console.Write("funciona");
        }

    }
}
