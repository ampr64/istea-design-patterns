namespace Hospital
{
    public interface IHealthProfessional
    {
        IHealthProfessional Superior { get; }

        void Treat(Patient patient);
    }
}