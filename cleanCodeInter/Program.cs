using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cleanCodeInter
{
    class Program
    {
        public static int typee;
        public static string nom;
        public static string post;
        public static string tache;
        public static string date;
        public static int debut;
        public static int fin;
        static void Main(string[] args)
        {

            Console.WriteLine("activity 1/robot 2");
            typee = Int32.Parse(Console.Read().ToString());

            Console.WriteLine("Poste(work../stundbuy)");
            post = Console.ReadLine().ToString();
            Console.WriteLine("nom/code");
            nom = Console.ReadLine().ToString();
            Console.WriteLine("tache(taski)");
            tache = Console.ReadLine().ToString();
            Console.WriteLine("heure debut");
            debut = Int32.Parse(Console.ReadLine().ToString());
            Console.WriteLine("heure fin");
            fin = Int32.Parse(Console.ReadLine().ToString());
            Console.WriteLine("date");
            date = Console.ReadLine().ToString();
            Console.WriteLine("ok");

            if (typee == 49) {

                Employe Peter = new Employe("nom");
                Factory factory = new Factory("");

                if (tache == "work")
                {
                    Peter.Work(debut, fin);
                }
                if (tache == "eat")
                {
                    Peter.Eat(debut, fin);
                }
                if (tache == "other")
                {
                    Peter.Other(debut, fin);
                }
                if (tache == "sleep")
                {
                    Peter.Sleep(debut, fin);
                }

                if (post == "task1") {
                    factory.Task1(Peter, date);
                }
                if (post == "task2")
                {
                    factory.Task2(Peter, date);
                }
                if (post == "task3")
                {
                    factory.Task3(Peter, date);
                }
                Console.WriteLine("La ligne à bien ete rajouter");
                Console.Read();
            }



            if (typee == 50)
            {

                Rebot R2B2 = new Rebot("nom");
                FactoryRobot factRb = new FactoryRobot("nom");

                if (post == "stundbuy")
                {
                    R2B2.Standby(debut, fin);
                }
               
                if (tache == "task1")
                {
                    factRb.Task1(R2B2, date);
                }
                if (tache == "task2")
                {
                    factRb.Task2(R2B2, date);
                }
                if (tache == "task3")
                {
                    factRb.Task3(R2B2, date);
                }
                Console.WriteLine("La ligne à bien ete rajouter");
                Console.Read();
            }
            
            Console.Read();
        }
    }
}