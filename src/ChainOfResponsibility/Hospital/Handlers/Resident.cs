using System;

namespace Hospital.Handlers
{
    public class Resident : HealthProfessional
    {
        public Resident(IHealthProfessional superior) : base(superior)
        {
            if (superior is null) throw new ArgumentNullException(nameof(superior));
        }

        protected override bool CanTreat(ConditionGravity gravity) => gravity == ConditionGravity.Mild;
    }
}