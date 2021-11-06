using System;

namespace SmartDevicesFactory.Decorator.Components
{
    public abstract class Television : IDevice
    {
        public bool IsOn { get; private set; }

        protected string Name => GetType().Name;

        public virtual void TurnOn()
        {
            if (IsOn)
                Console.WriteLine($"Cannot turn on {Name}, it's already on.");
            else
                TogglePower("on");
        }

        public virtual void TurnOff()
        {
            if (!IsOn)
                Console.WriteLine($"Cannot turn off {Name}, it's already off.");
            else
                TogglePower("off");
        }

        public virtual void PlayTv() => Play("TV");

        protected void TogglePower(string state)
        {
            Console.WriteLine($"Turning {state} {Name}.");
            IsOn = !IsOn;
        }

        protected void Play(string target)
        {
            if (!IsOn)
                Console.WriteLine($"{Name} is now playing {target}.");
            else
                Console.WriteLine($"{Name} cannot play {target} while it's off!");
        }
    }
}