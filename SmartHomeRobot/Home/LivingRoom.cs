using System;

namespace SmartHomeRobot.Home
{
    //Oturma Odası class'ı. HomeBase abstract sınıfını inherit ediyor. Perdesi olduğu için
    //ICurtainNumber interface'i ile perde numarasını tutan  metotu implement edildi.
    public class LivingRoom : HomeBase, ICurtainNumber
    {
        public void CurtainNumber()
        {
            Console.WriteLine("Has 2 Curtain");
        }

        public override void DoorNumber()
        {
            Console.WriteLine("Has 1 Door");
        }

        public override void LightNumber()
        {
            Console.WriteLine("Has 2 Pieces Light");

        }
    }
}
