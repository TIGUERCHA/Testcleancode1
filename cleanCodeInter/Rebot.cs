using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanCodeInter
{
    class Rebot : IRebot
    {
        public string Code { get; set; }
        public List<string> activityRebot = new List<string>();
        public Rebot(string code)
        {
            this.Code = code;
        }

        public void Standby(int debut, int fin)
        {
            activityRebot.Add(Code + ", Standbuy, " + debut.ToString() + "," + fin.ToString());
        }
    }
}
