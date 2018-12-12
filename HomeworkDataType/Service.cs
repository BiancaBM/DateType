using RetirementAge.Enums;
using System;

namespace RetirementAge
{
    public class Service : IService
    {

        public int Insert(InsertType type, int min, int max)
        {
            int result = 0;

            while(result == 0)
            {
                Console.Write(string.Format("Insert a valid {0} ({1} - {2}) :", type.ToString(), min, max));
                string valueInserted = Console.ReadLine();

                int parsedValue;
                bool parsedSuccesfuly = Int32.TryParse(valueInserted, out parsedValue);

                if (parsedSuccesfuly && parsedValue >= min && parsedValue <= max)
                {
                    result = parsedValue;
                }
            }

            return result;
        }

        public Gender InsertGender()
        {
            Gender? result = null;

            while (!result.HasValue)
            {
                Console.Write("Insert the gender (M/F) :");
                string valueInserted = Console.ReadLine();
                Gender parsedGender;
                if(Enum.TryParse(valueInserted, out parsedGender))
                {
                    result = parsedGender;
                }
            }
            return result.Value;
        }

        public void CheckIfPersonIsRetired(Gender gender, int year, int month, int day)
        {
            DateTime dateOfBirth = new DateTime(year, month, day);
            int actualAge = ((DateTime.Now - dateOfBirth).Days / 365);

            switch (gender)
            {
                case Gender.F:
                    if(actualAge >= (int)Gender.F)
                    {
                        Console.WriteLine("Female retired!");
                    } else
                    {
                        Console.WriteLine(string.Format("Retire age for female is {0}", (int)Gender.F));
                    }
                    break;
                case Gender.M:
                    if (actualAge >= (int)Gender.M)
                    {
                        Console.WriteLine("Male retired!");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Retire age for male is {0}", (int)Gender.M));
                    }
                    break;
            }
        }
    }
}
