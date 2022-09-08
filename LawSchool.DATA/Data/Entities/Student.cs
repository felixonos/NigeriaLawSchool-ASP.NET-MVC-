namespace LawSchool.Data.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EnumGender Gender { get; set; }

        public string Email { get; set; }

        public string SchoolAttend { get; set; }

        public DateTime GraduationYear { get; set; }
    }
}