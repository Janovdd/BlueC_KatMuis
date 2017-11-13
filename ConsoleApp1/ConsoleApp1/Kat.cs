using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kat
    {
        public Kat()
        {
            // ik doe hier even niets
        }

        public void Vang( Muis muis )
        {
            muis.Kill();
        }

        public override string ToString()
        {
            return "Dit is een kat die muizen opeet! Pas maar op!";
        }
    }
}
