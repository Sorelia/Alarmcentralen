using Alarmcentralen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen.Classes
{
    /// <summary>
    /// enum of severity
    /// </summary>
    enum specialty
    {
        Non_Lethal,
        Lethal
    }

    class Hospital : IHospital
    {
        private List<HospitalEmployee> employees = new List<HospitalEmployee>();
        List<HospitalEmployee> doctor = new List<HospitalEmployee>();
        List<HospitalEmployee> nurse = new List<HospitalEmployee>();
        private List<Patient> patients = new List<Patient>();

        public Hospital()
        {
            HireEmployee();
        }

        /// <summary>
        /// Gets a list of employees
        /// </summary>
        /// <returns></returns>
        public List<HospitalEmployee> GetHospitalEmployees()
        {
            return employees;
        }

        /// <summary>
        /// gets a list of patients
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            return patients;
        }
        /// <summary>
        /// Hires a total of 2 doctors and 6 nurses
        /// </summary>
        public void HireEmployee()
        {
            while (doctor.Count() < 3 && nurse.Count() < 7)
            {
                HospitalEmployee employee = new HospitalEmployee();
                if(employee.GetSpecialty() == "Lethal" && doctor.Count() < 3)
                {
                    doctor.Add(employee);
                } 
                else if(employee.GetSpecialty() == "Non_Lethal" && nurse.Count() < 7)
                {
                    nurse.Add(employee);
                }
            };

            foreach (var item in doctor)
            {
                employees.Add(item);
            }
            foreach (var item in nurse)
            {
                employees.Add(item);
            }
        }
    }
}
