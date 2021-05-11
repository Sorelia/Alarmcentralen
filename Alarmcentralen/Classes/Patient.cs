using Alarmcentralen.Classes;
using Alarmcentralen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen
{
    /// <summary>
    /// Patient Class, used to initilize a patient, including a list of their symptoms
    /// </summary>
    class Patient : IPatient
    {

        /// <summary>
        /// Properties
        /// </summary>
        private int id;
        private string name;
        private string severity;
        private List<string> symptoms = new List<string>();
        private HospitalEmployee employee;
        

        public Patient(string name)
        {
            RandomSymptoms rndSymptom = new RandomSymptoms(3);

            ///checks if id is 0, then id is 1 else id = id+1;
            if (id == 0) id = 1; 
            else id = GetID() + 1;

            this.name = name;

            /// sets the symptoms
            SetSymptoms(rndSymptom.GetRandomSymptom());

            /// Sets Severity
            SetSeverity();

            
        }

        public HospitalEmployee GetEmployee()
        {
            return employee;
        }

        /// <summary>
        /// returns the id
        /// </summary>
        /// <returns></returns>
        public int GetID()
        {
            return id;
        }

        /// <summary>
        /// returns the name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// returns the severity of symptoms
        /// </summary>
        /// <returns></returns>
        public string GetSeverity()
        {
            return severity;
        }

        /// <summary>
        /// returns a list of symptoms
        /// </summary>
        /// <returns></returns>
        public List<string> GetSymptoms()
        {
            return symptoms;
        }

        public void SetEmployee(HospitalEmployee employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// Sets Severity of symptoms
        /// </summary>
        public void SetSeverity()
        {
            if (symptoms.Contains("Heavy_Injury") || symptoms.Contains("Disrupted_Speaking_Pattern") 
                || symptoms.Contains("Disoriented") )
                severity = "Lethal";
            else
                severity = "Non_Lethal";
        }

        /// <summary>
        /// add symptoms to patient symptom list
        /// </summary>
        /// <param name="symptoms"></param>
        public void SetSymptoms(List<string> symptoms)
        {
            foreach (var symptom in symptoms)
            {
                this.symptoms.Add(symptom);
            }
        }
    }
}
