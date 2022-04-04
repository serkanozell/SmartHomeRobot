namespace SmartHomeRobot.Home
{
    //Birbirine benzer odaların özelliklerini merkezi bir yerden yönetebilmek için
    //homebase isimli sınıf soyut olarak kullanıldı.
    //Tüm odalar bu class ı inherit ediyor
    public abstract class HomeBase
    {
        public abstract void DoorNumber();
        public abstract void LightNumber();
    }
}
