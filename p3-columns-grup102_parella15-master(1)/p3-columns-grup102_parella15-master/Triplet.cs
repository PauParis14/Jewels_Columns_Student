using System;
using System.Collections.Generic;
using System.Text;

namespace Jewels_Columns_Student
{
    class Triplet
    {
        private Position pos;
        private List<Jewels> ThreeJewels = new List<Jewels>();
        //mètode estàtic generateRandomType de la classe Jewels.
        public Triplet(Position pos)
        {

        }

        public void SetPosition(Position pos)
        {

        }

        public Position GetPosition()
        {

        }

        public List<Jewels> GetThreeJewels()
        {

        }

        public void Draw()
            //primer situa el curso a l’atribut posició i crida al 
            //mètode Draw de la primera joia.

            //a continuació situació el curso a sobre i crida al 
            //mètode Draw de la segona joia.

            //per últim situació el curso a sobre i crida al mètode 
            //Draw de la tercera joia.
        {

        }

        public void Move(ConsoleKeyInfo key)
            //utilitzant un switch que segons l’entrada de l’usuari 
            //cridi els mètode MoveLeft, MoveRight, MoveDown si es 
            //polsen les seves fletxes i elmètode Sort si es 
            //polsa la barra espaiadora.
        {

        }

        private void MoveRight()
            //utilitzant el operador ++ de la posició per moure a 
            //la dreta i utilitza el mètode Grid.CheckPosition per 
            //comprovar la posició abans de modificar l’atribut posició.
        {

        }

        private void MoveLeft()
            //utilitzant el operador -- de la posició per moure a 
            //l’esquerra i utilitza el mètode Grid.CheckPosition per
            //comprovar la posició abans de modificar l’atribut posició.
        {

        }

        public void MoveDown()
            //utilitza el mètode Grid.CheckPosition per comprovar
            //la posició abans de modificar l’atribut posició.
        {

        }

        private void Sort()
            //que agafi la peça col·locada a la primera posició de la 
            //llista i la col·loqui a l’ultima posició de la llista,
            //pots utilitzar el mètode RemoveAt.
        {

        }

        public bool ContainMagic(ref Position p)
        //retorna:
            // False si cap de les tres peces són del tipus Magic.

            //True i la seva posició si troba una peça del tipus Magic, observa que la posició 
            //és un paràmetre que s’envia per referència.


        {
            Jewels m = new Magic();
            if (ThreeJewels[0].GetType() == m.GetType())
        }
    }
}
