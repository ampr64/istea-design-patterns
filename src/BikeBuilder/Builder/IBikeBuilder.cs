using BikeBuilder.Concrete;

namespace BikeBuilder.Builder
{
    public interface IBikeBuilder
    {
        void AddHandlebar();

        void AddWheel();

        void AddFrame();

        Bike Build();
    }
}