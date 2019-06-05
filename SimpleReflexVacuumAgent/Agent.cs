using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReflexVacuumAgent
{
    class Agent : AI
    {

        public void Percept()
        {
            System.Threading.Thread.Sleep(1000);
            left.Visible = true;
            if (right.Visible == true)
            {
                Suck(right);
                right.Visible = false;
            }
            else if (vacuumRight.Visible == true)
            {
                vacuumRight.Visible = false;
                vacuumLeft.Visible = true;
            }
            else { vacuumRight.Visible = true; }
            }

        public void Suck(PictureBox side)
        {
            side.Visible = false;
        }

    }
}
