using NLog;
using SmartHomeRobot.Home;
using System;

namespace SmartHomeRobot
{
    //Loglama sistemi NLog ile oluşturuldu. Program cs sınıfı aynı zamanda
    //mevcut logger class ı olarak belirtildi.
    //logger instance'ı ile her durumda robotun nerede olduğu takip edilebilir
    //keypress--> hangi durumda ne yapılacağı console üzerinden girileceği için
    //komutların eşleşmesi amacıyla yaratılmış variable
    //Kullanılan her nesnenin instance'ı yaratıldı
    //bathroom instance'ı abstract class örneğini kanıtlamak amacıyla
    //HomeBase abstract classından türetildi. Çünkü classlar arasında
    //HomeBase'i tam anlamıyla inherit eden tek class BathRoom class'ı.
    //Console'u kullanıcı istemediği sürece sürekli ayakta tutmak için
    //while döngüsü içerisinde true kullanılarak sonsuz döngü yaratıldı
    //girilen her key ile robotun görevini yerine getirip log alınmasının ardından
    //key press tekrar beklenir.
    //0 komutu ile robot başlangıç noktasına gönderilir ve şarj olmaya bırakılır
    //123 komutu ile uygulama kolayca kapatılabilir
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info("Application Started!!!");


            Console.WriteLine("Press 1 for Open Bath Light");
            Console.WriteLine("Press 11 for Close Bath Light");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 2 for Open Bedroom Light");
            Console.WriteLine("Press 22 for Close Bedroom Light");
            Console.WriteLine("Press 3 for Open Bedroom Curtain");
            Console.WriteLine("Press 33 for Close Bedroom Curtain");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 4 for Open Kitchen Light");
            Console.WriteLine("Press 44 for Close Kitchen Light");
            Console.WriteLine("Press 5 for Open Kitchen Curtain");
            Console.WriteLine("Press 55 for Close Kitchen Curtain");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 6 for Open Livingroom Light");
            Console.WriteLine("Press 66 for Close Livingroom Light");
            Console.WriteLine("Press 7 for Open Livingroom Curtain");
            Console.WriteLine("Press 77 for Close Livingroom Curtain");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 8 for Open Saloon Light");
            Console.WriteLine("Press 88 for Close Saloon Light");
            Console.WriteLine("Press 9 for Open Saloon Curtain");
            Console.WriteLine("Press 99 for Close Saloon Curtain");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 0 for stop robot");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press 123 for Close Application");





            int keyPress;

            Robot robot = new Robot();
            HomeBase bathRoom = new BathRoom();
            BedRoom bedRoom = new BedRoom();
            Kitchen kitchen = new Kitchen();
            LivingRoom livingRoom = new LivingRoom();
            Saloon saloon = new Saloon();

            while (true)
            {
                keyPress = Convert.ToInt32(Console.ReadLine());
                switch (keyPress)
                {
                    #region BathRoomCases
                    case 1:
                        robot.Move();
                        robot.OpenLight();
                        bathRoom.LightNumber();
                        Console.WriteLine("Robot Opened Bath Light");
                        logger.Info("Robot Opened Bath Light");
                        logger.Info("Last Location of Robot is Bath");
                        break;
                    case 11:
                        robot.Move();
                        robot.CloseLight();
                        Console.WriteLine("Robot Closed Bath Light");
                        logger.Info("Robot Closed Bath Light");
                        logger.Info("Last Location of Robot is Bath");
                        break;
                    #endregion
                    #region BedRoomCases
                    case 2:
                        robot.Move();
                        robot.OpenLight();
                        bedRoom.LightNumber();
                        Console.WriteLine("Robot Opened Bedroom Light");
                        logger.Info("Robot Opened Bedroom Light");
                        logger.Info("Last Location of Robot is Bedroom");
                        break;
                    case 22:
                        robot.Move();
                        robot.CloseLight();
                        Console.WriteLine("Robot Closed Bedroom Light");
                        logger.Info("Robot Closed Bedroom Light");
                        logger.Info("Last Location of Robot is Bedroom");
                        break;
                    case 3:
                        robot.Move();
                        robot.OpenCurtain();
                        bedRoom.CurtainNumber();
                        Console.WriteLine("Robot Opened Bedroom Curtain");
                        logger.Info("Robot Opened Bedroom Curtain");
                        logger.Info("Last Location of Robot is Bedroom");
                        break;
                    case 33:
                        robot.Move();
                        robot.CloseCurtain();
                        Console.WriteLine("Robot Closed Bedroom Curtain");
                        logger.Info("Robot Closed Bedroom Curtain");
                        logger.Info("Last Location of Robot is Bedroom");
                        break;
                    #endregion
                    #region KitchenCases
                    case 4:
                        robot.Move();
                        robot.OpenLight();
                        kitchen.LightNumber();
                        Console.WriteLine("Robot Opened Kitchen Light");
                        logger.Info("Robot Opened Kitchen Light");
                        logger.Info("Last Location of Robot is Kitchen");
                        break;
                    case 44:
                        robot.Move();
                        robot.CloseLight();
                        Console.WriteLine("Robot Closed Kitchen Light");
                        logger.Info("Robot Closed Kitchen Light");
                        logger.Info("Last Location of Robot is Kitchen");
                        break;
                    case 5:
                        robot.Move();
                        robot.OpenCurtain();
                        kitchen.CurtainNumber();
                        Console.WriteLine("Robot Opened Kitchen Curtain");
                        logger.Info("Robot Opened Kitchen Curtain");
                        logger.Info("Last Location of Robot is Kitchen");
                        break;
                    case 55:
                        robot.Move();
                        robot.CloseCurtain();
                        Console.WriteLine("Robot Closed Kitchen Curtain");
                        logger.Info("Robot Closed Kitchen Curtain");
                        logger.Info("Last Location of Robot is Kitchen");
                        break;
                    #endregion
                    #region LivingRoomCases
                    case 6:
                        robot.Move();
                        robot.OpenLight();
                        livingRoom.LightNumber();
                        Console.WriteLine("Robot Opened Livingroom Light");
                        logger.Info("Robot Opened Livingroom Light");
                        logger.Info("Last Location of Robot is Livingroom");
                        break;
                    case 66:
                        robot.Move();
                        robot.CloseLight();
                        Console.WriteLine("Robot Closed Livingroom Light");
                        logger.Info("Robot Closed Livingroom Light");
                        logger.Info("Last Location of Robot is Livingroom");
                        break;
                    case 7:
                        robot.Move();
                        robot.OpenCurtain();
                        livingRoom.CurtainNumber();
                        Console.WriteLine("Robot Opened Livingroom Curtain");
                        logger.Info("Robot Opened Livingroom Curtain");
                        logger.Info("Last Location of Robot is Curtain");
                        break;
                    case 77:
                        robot.Move();
                        robot.CloseCurtain();
                        Console.WriteLine("Robot Closed Livingroom Curtain");
                        logger.Info("Robot Closed Livingroom Curtain");
                        logger.Info("Last Location of Robot is Livingroom");
                        break;
                    #endregion
                    #region SaloonCases
                    case 8:
                        robot.Move();
                        robot.OpenLight();
                        saloon.LightNumber();
                        Console.WriteLine("Robot Opened Saloon Light");
                        logger.Info("Robot Opened Saloon Light");
                        logger.Info("Last Location of Robot is Saloon");
                        break;
                    case 88:
                        robot.Move();
                        robot.CloseLight();
                        Console.WriteLine("Robot Closed Saloon Light");
                        logger.Info("RRobot Closed Saloon Light");
                        logger.Info("Last Location of Robot is Saloon");
                        break;
                    case 9:
                        robot.Move();
                        robot.OpenCurtain();
                        saloon.CurtainNumber();
                        Console.WriteLine("Robot Opened Saloon Curtain");
                        logger.Info("RRobot Opened Saloon Curtain");
                        logger.Info("Last Location of Robot is Saloon");
                        break;
                    case 99:
                        robot.Move();
                        robot.OpenCurtain();
                        saloon.CurtainNumber();
                        Console.WriteLine("Robot Closed Saloon Curtain");
                        logger.Info("RRobot Closed Saloon Curtain");
                        logger.Info("Last Location of Robot is Saloon");
                        break;
                    #endregion
                    #region DefaultCase
                    case 0:
                        robot.Move();
                        robot.Stop();
                        logger.Info("Robot Going to Charge!!!");
                        break;
                    #endregion
                    #region ShutCase
                    case 123:
                        logger.Info("Application Closed!!!");
                        Environment.Exit(123);
                        break;
                        #endregion
                }
            }
        }
    }
}
