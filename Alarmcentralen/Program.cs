using Alarmcentralen.Classes;
using System;

namespace Alarmcentralen
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            foreach (var employee in hospital.GetHospitalEmployees())
            {
                Console.WriteLine("Employee Name: " + employee.GetName());
                Console.WriteLine("Employee Type: " + employee.GetEmployeeType());
                Console.WriteLine("Employee Specialty: " + employee.GetSpecialty());
                Console.WriteLine("Employee Maximum Patients: " + employee.GetMaximumPatients() + "\r\n"); 
            }

            Patient patientX = new Patient("Patient X");
            Console.WriteLine("Patient ID: " + patientX.GetID());
            Console.WriteLine("Patient Name: " + patientX.GetName());
            int i = 1;
            foreach (var symptom in patientX.GetSymptoms())
            {
                Console.WriteLine($"Patient symptom: {i} " + symptom);
                i++;
            }
            Console.WriteLine("Patient Severity: " + patientX.GetSeverity() + "\r\n");

            
            Console.ReadKey();
        }
    }
}
       /*if(Jenny.GetSpecialty() == patientX.GetSeverity())
            {
                Jenny.AddPatient(patientX);
                Console.WriteLine(patientX.GetName() + " Has been assigned to " + Jenny.GetEmployeeType() + " " + Jenny.GetName());
            } else
            {
                Drew.AddPatient(patientX);
                Console.WriteLine(patientX.GetName() + " Has been assigned to " + Drew.GetEmployeeType() + " " + Drew.GetName());
            }*/