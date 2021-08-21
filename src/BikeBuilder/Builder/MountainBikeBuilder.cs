using BikeBuilder.Concrete;

namespace BikeBuilder.Builder
{
    public class MountainBikeBuilder : IBikeBuilder
    {
        private readonly Bike _bike = new();

        public void AddFrame()
        {
            _bike.Frame = new MountainBikeFrame();
        }

        public void AddHandlebar()
        {
            _bike.Handlebar = new MountainBikeHandlebar();
        }

        public void AddWheel()
        {
            _bike.Wheel = new MountainBikeWheel();
        }

        public Bike Build() => _bike;
    }
}