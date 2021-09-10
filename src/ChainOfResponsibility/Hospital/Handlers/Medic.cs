using System;

namespace Hospital.Handlers
{
    public class Medic : HealthProfessional
    {
        public Medic(IHealthProfessional superior) : base(superior)
        {
            if (superior is null) throw new ArgumentNullException(nameof(superior));
            if (superior.GetType() != typeof(Specialist)) throw new ArgumentException("Medics can only have specialists as superiors.");
        }

        protected override bool CanTreat(ConditionGravity gravity) => gravity == ConditionGravity.Moderate;
    }
}