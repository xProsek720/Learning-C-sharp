﻿using System.Collections;
using System.Collections.Generic;
namespace Rodzajowe_i_nierodzajowe_Zbiory
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Nieodzajowy zbiór:
            
            //Bez definiowania ilości elementów
            ArrayList arrayList = new ArrayList();
            //Zdefiniowania ilośc elementów
            ArrayList arrayList2= new ArrayList(3);
        
            //Metoda Add
            arrayList.Add(4);
            arrayList.Add(2);
            arrayList.Add(2.3);
            arrayList.Add(2.3f);
            arrayList.Add("FN");
            arrayList.Add('F');
            arrayList.Add("Nice");

            arrayList2.Add("Let's go!");
            arrayList2.Add("Broke");
            arrayList2.Add(1424);


            //Metoda Remove
            arrayList.Remove("Nice");

            //Metoda Remove At
            arrayList2.RemoveAt(1);


            arrayList2.Add("Everyday");
            //Moglo by byc cos bardziej kreatywnego, ale sa swieta
            // i mam inne plany B)
            Console.Write("arrayList: ");
            foreach(object obj in arrayList) 
            {
                Console.Write($"{obj} ");
            }
            Console.Write("\n");

            Console.Write("arrayList2: ");
            foreach(object obj in arrayList2) 
            {
                Console.Write($"{obj} ");
            }
            Console.Write("\n");


        //Rodzajowy zbiór:
            //To w kolejnych push'ach!
            List<string> list = new List<string>();

            //Dodawanie
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");

            //Usuwanie
            list.Remove("3");

            //Usuwanie z Pozycji
            list.RemoveAt(1);   //Usuwa 2jke

            Console.Write("Lista: ");
            foreach (string element in list) 
            {
                Console.Write($"{element} ");
            }
            Console.ReadLine();



        }
    }
}