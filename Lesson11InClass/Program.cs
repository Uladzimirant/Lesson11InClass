namespace Lesson11InClass
{
    public class Program
    {
        public static void Main()
        {
            PingPongPlayer ping = new PingPongPlayer("Ping");
            PingPongPlayer pong = new PingPongPlayer("Pong");
            ping.RegisterWith(pong);
            pong.RegisterWith(ping);
            ping.BeginPlay();
        }
    }
}
