using Hospital.Handlers;

namespace Hospital
{
    class Program
    {
        static void Main()
        {
            var mildPatient = new Patient(ConditionGravity.Mild);
            var moderatePatient = new Patient(ConditionGravity.Moderate);
            var criticalPatient = new Patient(ConditionGravity.Critical);

            var resident = new Resident(
                new Medic(
                    new Specialist()));

            resident.Treat(mildPatient);
            resident.Treat(moderatePatient);
            resident.Treat(criticalPatient);
        }
    }
}