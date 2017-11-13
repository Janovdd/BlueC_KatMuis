using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Muis
    {
        private bool isLevend;

        public Muis()
        {
            // zet isLevend op true
        }

        public void Kill()
        {
            // zet isLevend op false
        }

        public override string ToString()
        {
            if(this.isLevend)
            {
                return "Nog steeds levend haha!";
            } else
            {
                return "...";
            }
        }
    }
}
