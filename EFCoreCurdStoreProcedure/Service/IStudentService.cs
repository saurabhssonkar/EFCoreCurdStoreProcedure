using EFCoreCurdStoreProcedure.Models;
using System.Collections.Generic;

namespace EFCoreCurdStoreProcedure.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents(string name);

        void SaveOrUpdateStudent(Student student);

        void Delete(int studentId);

    }
}
