using System;

namespace SmartHomeRobot.Home
{
    //Banyo class'ı. HomeBase abstract sınıfını inherit ediyor. Perdesi olmadığı için
    //interface ile perde numarasını tutmuyor.
    public class BathRoom : HomeBase
    {
        public override void DoorNumber()
        {
            Console.WriteLine("Has 1 Door");
        }

        public override void LightNumber()
        {
            Console.WriteLine("Has 2 Light");
        }
    }
}
