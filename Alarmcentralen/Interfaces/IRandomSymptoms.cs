using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen.Interfaces
{
    /// <summary>
    /// Interface for random symptoms
    /// </summary>
    interface IRandomSymptoms
    {
        List<string> GetRandomSymptom();
        void SetRandomSymptoms(int amount);
    }
}
