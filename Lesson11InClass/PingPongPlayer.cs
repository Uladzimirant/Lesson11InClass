using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11InClass
{
    public class PingPongPlayer
    {
        private string _name;
        event EventHandler<int>? PingPongEvent;

        public PingPongPlayer(string name)
        {
            _name = name;
        }

        public void Play(object? sender, int amount)
        {
            Console.WriteLine(_name + " recieved " + sender);
            Thread.Sleep(100);
            PingPongEvent?.Invoke(this, amount + 1);
            if (amount < 100) (sender as PingPongPlayer)?.PingPongEvent?.Invoke(this, amount + 1);
        }

        public void RegisterWith(PingPongPlayer p)
        {
            p.PingPongEvent += Play;
        }
        public void BeginPlay()
        {
            PingPongEvent?.Invoke(this, 0);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
