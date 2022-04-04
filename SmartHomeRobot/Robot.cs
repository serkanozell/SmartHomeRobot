using SmartHomeRobot.Move;
using SmartHomeRobot.MoveAndStop;
using SmartHomeRobot.OpenClose;
using System;

namespace SmartHomeRobot
{
    //İsteklerimizi yerine getirecek olan robot sınıfımız.
    //İçerisinde birden fazla interface ile kazanmış olduğu özellikler mevcut.
    //İnterfaceleri tek tek parçalamamdaki amaç bunun bir best practise olmasıdır.
    //Bu sayede ileride bir özellik eklemek yada çıkarmak istediğimizde yapmamız gereken
    //tek şek yeni bir interface ile bu özelliği kazandırmak yada çıkarmak olacaktır

    public class Robot : IMove, IStop, ILightOpen, ILightClose, ICurtainOpen, ICurtainClose
    {
        public void OpenLight()
        {
            Console.WriteLine("Light Opened");
        }
        public void CloseLight()
        {
            Console.WriteLine("Light Closed");
        }
        public void OpenCurtain()
        {
            Console.WriteLine("Curtain Opened");
        }

        public void CloseCurtain()
        {
            Console.WriteLine("Curtain Closed");
        }
        public void Move()
        {
            Console.WriteLine("Robot Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Robot going to charge");
        }
    }
}
