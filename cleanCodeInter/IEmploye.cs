using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanCodeInter
{
    interface IEmploye
    {
        void Work(int debut, int fin);
        void Eat(int debut, int fin);
        void Other(int debut, int fin);
        void Sleep(int debut, int fin);
    }
}
