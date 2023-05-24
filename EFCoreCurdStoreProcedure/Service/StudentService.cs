using EFCoreCurdStoreProcedure.Context;
using EFCoreCurdStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreCurdStoreProcedure.Service
{
    public class StudentService : IStudentService
    {
        DatabaseContex _dbContex = null;

        public StudentService(DatabaseContex dbContex)
        {
            _dbContex = dbContex;


        }
        public void Delete(int studentId)
        {
            _dbContex.Database.ExecuteSqlRaw($"DeleteStudent {studentId}");
            var students = _dbContex.Students.ToList();
        }

        public List<Student> GetStudents(string name)
        {

            var students = _dbContex.Students.FromSqlRaw($"GetStudents {name}").ToList();
            return students;

        }

        public void SaveOrUpdateStudent(Student student)
        {
            _dbContex.Database.ExecuteSqlRaw($"SaveOrUpdateStudent {student.StudentId},{student.Name},{student.Age}");

            //TEST

            var students = _dbContex.Students.ToList();
        }
    }
}