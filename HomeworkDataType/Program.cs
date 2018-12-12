using RetirementAge.Enums;
using System;

namespace RetirementAge
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new Service();

            int day = service.Insert(InsertType.Day, 1, 31);
            int month = service.Insert(InsertType.Month, 1, 12);
            int year = service.Insert(InsertType.Year, 1900, DateTime.Now.Year);
            Gender gender = service.InsertGender();

            service.CheckIfPersonIsRetired(gender, year, month, day);
        }
    }
}
