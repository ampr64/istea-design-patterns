using BikeBuilder.Concrete;

namespace BikeBuilder.Builder
{
    public class BeachCruiserBikeBuilder : IBikeBuilder
    {
        private readonly Bike _bike = new Bike();

        public void AddFrame()
        {
            _bike.Frame = new BeachCruiserBikeFrame();
        }

        public void AddHandlebar()
        {
            _bike.Handlebar = new BeachCruiserBikeHandlebar();
        }

        public void AddWheel()
        {
            _bike.Wheel = new BeachCruiserBikeWheel();
        }

        public Bike Build() => _bike;
    }
}