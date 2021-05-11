using Alarmcentralen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmcentralen.Classes
{
    /// <summary>
    /// enum of symptoms
    /// </summary>
    enum symptom
    {
        Cough,
        Slight_Fever,
        Cold,
        Small_Injury,
        Heavy_Injury,
        Rash,
        Disrupted_Speaking_Pattern,
        Disoriented
    }
    class RandomSymptoms : IRandomSymptoms
    {
        Random rnd = new(); // Initializes new random
        List<string> symptoms = new List<string>();

        public RandomSymptoms(int amount)
        {
            SetRandomSymptoms(amount);
        }
        /// <summary>
        /// Gets the symptoms
        /// </summary>
        /// <returns></returns>
        public List<string> GetRandomSymptom()
        {
            return symptoms;
        }

        /// <summary>
        /// Generates x amount of random symptoms
        /// </summary>
        /// <param name="amount"></param>
        public void SetRandomSymptoms(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                switch (rnd.Next(0, 7))
                {
                    case 0:
                        if (symptoms.Contains("Cough"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Cough));
                        }
                        break;
                    case 1:
                        if (symptoms.Contains("Slight_Fever"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Slight_Fever));
                        }
                        break;
                    case 2:
                        if (symptoms.Contains("Cold"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Cold));
                        }
                        break;
                    case 3:
                        if (symptoms.Contains("Small_Injury"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Small_Injury));
                        }
                        break;
                    case 4:
                        if (symptoms.Contains("Heavy_Injury"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Heavy_Injury));
                        }
                        break;
                    case 5:
                        if (symptoms.Contains("Rash"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Rash));
                        }
                        break;
                    case 6:
                        if (symptoms.Contains("Disrupted_Speaking_Pattern"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Disrupted_Speaking_Pattern));
                        }
                        break;
                    case 7:
                        if (symptoms.Contains("Disoriented"))
                        {
                            i--;
                        }
                        else
                        {
                            symptoms.Add(Convert.ToString(symptom.Disoriented));
                        }
                        break;
                }
            }
        }
    }
}
