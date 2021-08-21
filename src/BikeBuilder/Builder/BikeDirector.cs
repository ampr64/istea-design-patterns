using BikeBuilder.Concrete;
using System;

namespace BikeBuilder.Builder
{
    public class BikeDirector
    {
        private IBikeBuilder _bikeBuilder;

        public BikeDirector(IBikeBuilder bikeBuilder) => _bikeBuilder = bikeBuilder ?? throw new ArgumentNullException(nameof(bikeBuilder));

        public void SetBuilder(IBikeBuilder bikeBuilder) => _bikeBuilder = bikeBuilder ?? throw new ArgumentNullException(nameof(bikeBuilder));

        public Bike BuildBike()
        {
            _bikeBuilder.AddFrame();
            _bikeBuilder.AddHandlebar();
            _bikeBuilder.AddWheel();

            return _bikeBuilder.Build();
        }
    }
}