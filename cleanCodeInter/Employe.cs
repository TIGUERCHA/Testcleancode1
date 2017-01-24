using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanCodeInter
{
    class Employe : IEmploye
    {
        enum task { Task1, Task2, Task3};
        public string name { get; set; }
        //public string[] activity { get; set; }
        public List<string> activity = new List<string>();
        task tsk;
        public Employe(string name)
        {
            this.name = name;
            Console.WriteLine("gestion de l'employe "+ name);
        }
        public void Work(int debut, int fin)
        {
            activity.Add(name+", Work, "+debut.ToString()+","+fin.ToString());
            creatfilecsv(name + ", Work, " + debut.ToString() + "," + fin.ToString());
        }
        public void Eat(int debut, int fin)
        {
            activity.Add(name + ", Eat, " + debut.ToString() + "," + fin.ToString());
            creatfilecsv(name + ", Eat, " + debut.ToString() + "," + fin.ToString());
        }
        public void Other(int debut, int fin)
        {
            activity.Add(name + ", Other, " + debut.ToString() + "," + fin.ToString());
            creatfilecsv(name + ", Other, " + debut.ToString() + "," + fin.ToString());
        }
        public void Sleep(int debut, int fin)
        {
            activity.Add(name + ", Sleep, " + debut.ToString() + "," + fin.ToString());
            creatfilecsv(name + ", Sleep, " + debut.ToString() + "," + fin.ToString());
        }

        public void creatfilecsv(string chaine)
        {
            var csv = new StringBuilder();
            var firstLine = chaine;
            csv.AppendLine(firstLine);
            //csv.AppendLine("Info1;Info 2 avec espaces");
            System.IO.File.WriteAllText("C:\\Users\\utilisateur\\Desktop\\repertoircsv\\TonFichier.csv", csv.ToString());
        }
    }
}
