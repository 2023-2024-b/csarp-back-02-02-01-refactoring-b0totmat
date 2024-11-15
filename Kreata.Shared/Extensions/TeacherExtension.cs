using Kreata.Shared.Dtos;
using Kreata.Shared.Models.Entities;

namespace Kreata.Shared.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                BirthDay = teacher.BirthDay,
                FirstName = teacher.FirstName,
                Id = teacher.Id,
                IsHeadTeacher = teacher.IsHeadTeacher,
                IsWoman = teacher.IsWoman,
                LastName = teacher.LastName,
                MathersName = teacher.MathersName,
                PlaceOfBirth = teacher.PlaceOfBirth
            };
        }

        public static Teacher ToModel(this TeacherDto teacherDto)
        {
            return new Teacher
            {
                BirthDay = teacherDto.BirthDay,
                FirstName = teacherDto.FirstName,
                Id = teacherDto.Id,
                IsHeadTeacher = teacherDto.IsHeadTeacher,
                IsWoman = teacherDto.IsWoman,
                LastName = teacherDto.LastName,
                MathersName = teacherDto.MathersName,
                PlaceOfBirth = teacherDto.PlaceOfBirth
            };
        }
    }
}
