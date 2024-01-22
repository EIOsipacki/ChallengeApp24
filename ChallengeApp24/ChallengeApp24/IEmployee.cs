
using static ChallengeApp24.EmployeeBase;

namespace ChallengeApp24
{
    internal interface IEmployee
    {
        string Name { get; }
        string SurName { get; }

        
        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();

    }
}
