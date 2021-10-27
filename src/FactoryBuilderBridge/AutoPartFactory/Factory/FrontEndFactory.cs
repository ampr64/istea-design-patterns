using AutoPartFactory.Model;
using System;

namespace AutoPartFactory.Factory
{
    public class FrontEndFactory : IFrontEndFactory
    {
        public TFrontEnd Create<TFrontEnd>(SteeringType steeringType) =>
            (TFrontEnd)Activator.CreateInstance(typeof(TFrontEnd), steeringType);
    }
}