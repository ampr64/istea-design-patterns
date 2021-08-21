using BikeBuilder.Builder;
using System;

namespace BikeBuilder
{
    class Program
    {
        static void Main()
        {
            MountainBikeBuilder mountainBikeBuilder = new();
            BeachCruiserBikeBuilder beachCruiserBikeBuilder = new();

            BikeDirector bikeDirector = new(mountainBikeBuilder);

            var bike = bikeDirector.BuildBike();            
            bike.DisplayBikeInfo();

            bikeDirector.SetBuilder(beachCruiserBikeBuilder);

            bike = bikeDirector.BuildBike();
            Console.WriteLine();
            bike.DisplayBikeInfo();

            Console.ReadKey();
        }
    }
}
