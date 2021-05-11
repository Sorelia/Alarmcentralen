using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen.Interfaces
{
    interface IHospital
    {
        List<HospitalEmployee> GetHospitalEmployees();
        void HireEmployee();
        List<Patient> GetPatients();
        
    }
}
