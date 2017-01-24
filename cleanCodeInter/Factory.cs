using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanCodeInter
{
    class Factory : Employe , IEmploye
    {
        public Factory(string name) : base(name)
        {
        }
        public void Task1(Employe employe, string date) {
            base.activity.Add(employe.name.ToString() + ", Task1, " + date.ToString());
            creatfilecsv(employe.name.ToString() + ", Task1, " + date.ToString());
        }
        public void Task2(Employe employe, string date)
        {
            base.activity.Add(employe.name.ToString() + ", Task2, " + date.ToString());
            creatfilecsv(employe.name.ToString() + ", Task2, " + date.ToString());
        }
        public void Task3(Employe employe, string date)
        {
            base.activity.Add(employe.name.ToString() + ", Task3, " + date.ToString());
            creatfilecsv(employe.name.ToString() + ", Task3, " + date.ToString());
        }

        public void creatfilecsv(string chaine) {
            var csv = new StringBuilder();
            var firstLine = chaine;
            csv.AppendLine(firstLine);
            //csv.AppendLine("Info1;Info 2 avec espaces");
            System.IO.File.WriteAllText("C:\\Users\\utilisateur\\Desktop\\repertoircsv\\TonFichier.csv", csv.ToString());
        }
    }
}
