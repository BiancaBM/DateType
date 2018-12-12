using RetirementAge.Enums;
using System;

namespace RetirementAge
{
    public interface IService
    {
        int Insert(InsertType type, int min, int max);
        Gender InsertGender();
        void CheckIfPersonIsRetired(Gender gender, int year, int month, int day);
    }
}
