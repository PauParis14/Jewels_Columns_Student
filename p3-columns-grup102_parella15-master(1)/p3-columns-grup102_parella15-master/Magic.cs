using System;
using System.Collections.Generic;
using System.Text;

namespace Jewels_Columns_Student
{
    class Magic:Jewels
    {
        public ConsoleColor COLOR_MAGIC = ConsoleColor.Gray;
        private char SIMBOL = '*';
        //implementar mètode abstracte i utilitzar la paraula override
        //utilitzar l'atribut ForegroundColor de la classe Console per
        //definir el color i escriu el caràcter de la constant símbol.


        public Magic()
            //A continuació del nom del constructor de la classe filla
            //cal posar dos punts i utilitzar la paraula base per
            //cridar el constructor de la classe abstracta.
        {

        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(SIMBOL);
        }
    }
}
