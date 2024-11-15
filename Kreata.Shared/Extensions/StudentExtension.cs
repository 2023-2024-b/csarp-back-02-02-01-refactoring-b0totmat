using Kreata.Shared.Dtos;
using Kreata.Shared.Models.Entities;

namespace Kreata.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto()
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthsDay = student.BirthsDay,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
                EducationLevel = student.EducationLevel
            };
        }

        public static Student ToStudent(this StudentDto studentDto)
        {
            return new Student
            {
                BirthsDay = studentDto.BirthsDay,
                EducationLevel = studentDto.EducationLevel,
                FirstName = studentDto.FirstName,
                Id = studentDto.Id,
                IsWoomen = studentDto.IsWoomen,
                LastName = studentDto.LastName,
                SchoolClass = studentDto.SchoolClass,
                SchoolYear = studentDto.SchoolYear
            };
        }
    }
}
