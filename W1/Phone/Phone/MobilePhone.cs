using System;
using System.Collections.Generic;
using System.Text;

namespace Phone
{
    class MobilePhone
    {
        public Screen Screen { get; set; }
        public Camera Camera { get; set; }
        public MobilePhone(Screen scr, Camera cam)
        {
            this.Screen = scr;
            this.Camera = cam;
        }
    }

    class Screen
    {

    }

    class Camera
    {

    }


    class FmMoblePhone : MobilePhone
    {
        public string FmAntenna { get; set; }
        public void Call()
        {

        }
     
    }

    class PenMobilePhone : MobilePhone
    {
        public string Pen { get; set; }
        public void Draw()
        {

        }
    }
}
