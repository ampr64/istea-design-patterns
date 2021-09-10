namespace Hospital.Handlers
{
    public class Specialist : HealthProfessional
    {
        protected override bool CanTreat(ConditionGravity gravity) => gravity == ConditionGravity.Critical;
    }
}