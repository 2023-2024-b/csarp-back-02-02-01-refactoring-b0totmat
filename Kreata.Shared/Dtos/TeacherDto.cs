namespace Kreata.Shared.Dtos
{
    public class TeacherDto
    {
        public TeacherDto()
        {
        }

        public TeacherDto(Guid id, string firstName, string lastName, DateTime birthDay, string placeOfBirth, bool isWoman, bool isHeadTeacher, string mathersName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
            MathersName = mathersName;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public string MathersName { get; set; }
    }
}
