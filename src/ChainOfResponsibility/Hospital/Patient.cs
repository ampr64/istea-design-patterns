namespace Hospital
{
    public class Patient
    {
        public ConditionGravity ConditionGravity { get; }

        public Patient(ConditionGravity conditionGravity) => ConditionGravity = conditionGravity;
    }
}