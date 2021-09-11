using System;

namespace Hospital
{
    public abstract class HealthProfessional : IHealthProfessional
    {
        public IHealthProfessional Superior { get; }

        public HealthProfessional() { }

        protected HealthProfessional(IHealthProfessional superior)
        {
            if (GetType() == Superior?.GetType()) throw new ArgumentException("Superior cannot be of the same type as current professional.");
            Superior = superior;
        }

        protected abstract bool CanTreat(ConditionGravity gravity);

        public void Treat(Patient patient)
        {
            if (CanTreat(patient.ConditionGravity))
            {
                Console.WriteLine($"This patient with a {patient.ConditionGravity.ToString().ToLower()} condition is being treated by a {GetType().Name.ToLower()}.");
                return;
            }

            Superior?.Treat(patient);
            Console.WriteLine("This patient couldn't be treated.");
        }
    }
}