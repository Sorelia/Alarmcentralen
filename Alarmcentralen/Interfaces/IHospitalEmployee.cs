using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen
{
    /// <summary>
    /// Small interface for the Nurse and Doctor class
    /// </summary>
    interface IHospitalEmployee
    {
        /// <summary>
        /// gets name
        /// </summary>
        /// <returns></returns>
        string GetName();
        /// <summary>
        /// gets patients
        /// </summary>
        /// <returns></returns>
        List<Patient> GetPatients();
        /// <summary>
        /// adds patient to list
        /// </summary>
        /// <param name="patient"></param>
        void AddPatient(Patient patient);
        /// <summary>
        /// remove patient from list
        /// </summary>
        /// <param name="patient"></param>
        void RemovePatient(Patient patient);
        /// <summary>
        /// returns the specialty
        /// </summary>
        /// <returns></returns>
        string GetSpecialty();
        /// <summary>
        /// returns employee type
        /// </summary>
        /// <returns></returns>
        string GetEmployeeType();
        /// <summary>
        /// Checks maximum patients
        /// </summary>
        /// <returns></returns>
        int CheckMaximumPatients();
        /// <summary>
        /// Gets maximum patients
        /// </summary>
        /// <returns></returns>
        int GetMaximumPatients();
        /// <summary>
        /// Assigns a patient to an employee
        /// </summary>
        /// <param name="patient"></param>
        bool AssignPatient(Patient patient);

        void SetRandomName();

        void SetRandomSpecialty();
    }
}
