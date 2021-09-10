using System;

namespace Hospital.Handlers
{
    public class Resident : HealthProfessional
    {
        public Resident(IHealthProfessional superior) : base(superior)
        {
            if (superior is null) throw new ArgumentNullException(nameof(superior));
            if (superior.GetType() != typeof(Medic)) throw new ArgumentException("Residents can only have medics as superiors.");
        }
        protected override bool CanTreat(ConditionGravity gravity) => gravity == ConditionGravity.Mild;
    }
}