using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen
{
    /// <summary>
    /// Class for the Hospital Employees
    /// </summary>
    class HospitalEmployee : IHospitalEmployee
    {
        /// <summary>
        /// Properties
        /// </summary>
        private string name;
        private string specialty;
        private List<Patient> patients;
        private string typeOfEmployee;

        enum names
        {
            Jennifer,
            Cara,
            Rick,
            Carl,
            Drew,
            Julia,
            Carol,
            Dayle,
            Alice,
            Sarah
        }

        public HospitalEmployee()
        {
            SetRandomName();
            SetRandomSpecialty();
            patients = new List<Patient>(CheckMaximumPatients());

            if (specialty == "Non_Lethal")
            {
                typeOfEmployee = "Nurse";
            }
            else
            {
                typeOfEmployee = "Doctor";
            }
        }

        /// <summary>
        /// Returns the name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Returns the list of patients
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            return patients;
        }

        /// <summary>
        /// Returns a string of the specialty
        /// </summary>
        /// <returns></returns>
        public string GetSpecialty()
        {
            return specialty;
        }

        /// <summary>
        /// Adds a patient to the list of patients
        /// </summary>
        /// <param name="patient"></param>
        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        /// <summary>
        /// Removes a patient if it is in the list
        /// </summary>
        /// <param name="patient"></param>
        public void RemovePatient(Patient patient)
        {
            if(patients.Contains(patient))
            {
                patients.Remove(patient);
            }
        }

        /// <summary>
        /// returns the type of employee
        /// </summary>
        /// <returns></returns>
        public string GetEmployeeType()
        {
            return typeOfEmployee;
        }

        /// <summary>
        /// Decides Maximum patients based on if a Doctor or Nurse
        /// </summary>
        /// <returns></returns>
        public int CheckMaximumPatients()
        {
            if(typeOfEmployee == "Nurse")
            {
                return 3;
            }
            else {
                return 1;
            }
        }

        /// <summary>
        /// Gets maximum amounts of patients
        /// </summary>
        /// <returns></returns>
        public int GetMaximumPatients()
        {
            return CheckMaximumPatients();
        }

        /// <summary>
        /// Assigns the patient and employee to each other
        /// </summary>
        /// <param name="patient"></param>
        public bool AssignPatient(Patient patient)
        {
            if (this.GetSpecialty() == patient.GetSeverity())
            {
                if (this.GetPatients().Count < 3)
                {
                    this.AddPatient(patient);
                    patient.SetEmployee(this);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public void SetRandomName()
        {
            Random rnd = new();
            switch (rnd.Next(0, 9))
            {
                case 0:
                    name = Convert.ToString(names.Jennifer);
                    break;
                case 1:
                    name = Convert.ToString(names.Cara);
                    break;
                case 2:
                    name = Convert.ToString(names.Rick);
                    break;
                case 3:
                    name = Convert.ToString(names.Carl);
                    break;
                case 4:
                    name = Convert.ToString(names.Drew);
                    break;
                case 5:
                    name = Convert.ToString(names.Julia);
                    break;
                case 6:
                    name = Convert.ToString(names.Carol);
                    break;
                case 7:
                    name = Convert.ToString(names.Dayle);
                    break;
                case 8:
                    name = Convert.ToString(names.Alice);
                    break;
                case 9:
                    name = Convert.ToString(names.Sarah);
                    break;
            }
        }
        public void SetRandomSpecialty()
        {
            Random rnd = new();
            switch (rnd.Next(0, 1))
            {
                case 0:
                    specialty = "Non_Lethal";
                    break;
                case 1:
                    specialty = "Lethal";
                    break;
            }
        }
    }
}
