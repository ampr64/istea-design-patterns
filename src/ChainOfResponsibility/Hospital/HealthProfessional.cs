﻿using System;

namespace Hospital
{
    public abstract class HealthProfessional : IHealthProfessional
    {
        public IHealthProfessional Superior { get; }

        protected HealthProfessional() { }

        protected HealthProfessional(IHealthProfessional superior) => Superior = superior;

        protected abstract bool CanTreat(ConditionGravity gravity);

        public void Treat(Patient patient)
        {
            if (CanTreat(patient.ConditionGravity))
            {
                Console.WriteLine($"This patient with a {patient.ConditionGravity.ToString().ToLower()} condition is being treated by a {GetType().Name.ToLower()}.");
                return;
            }

            if (Superior is null)
            {
                Console.WriteLine("This patient couldn't be treated.");
                return;
            }

            Superior.Treat(patient);
        }
    }
}