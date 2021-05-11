using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen.Interfaces
{
    /// <summary>
    /// Interface for the patient class
    /// </summary>
    interface IPatient
    {
        /// <summary>
        /// returns patient ID
        /// </summary>
        /// <returns></returns>
        int GetID();
        /// <summary>
        /// returns patient name
        /// </summary>
        /// <returns></returns>
        string GetName();
        /// <summary>
        /// returns severity of symptoms
        /// </summary>
        /// <returns></returns>
        string GetSeverity();
        /// <summary>
        /// returns a list of symptoms
        /// </summary>
        /// <returns></returns>
        List<string> GetSymptoms();
        /// <summary>
        /// Sets the symptoms
        /// </summary>
        /// <param name="symptoms"></param>
        void SetSymptoms(List<string> symptoms);
        /// <summary>
        /// Sets Severity of symptoms
        /// </summary>
        void SetSeverity();
        /// <summary>
        /// Gets the employee assigned to the patient
        /// </summary>
        /// <returns></returns>
        HospitalEmployee GetEmployee();
        /// <summary>
        /// sets the employee to patient
        /// </summary>
        /// <param name="employee"></param>
        void SetEmployee(HospitalEmployee employee);
    }
}
