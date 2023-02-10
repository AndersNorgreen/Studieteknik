namespace TECEnrollment
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set;}
        public string TeacherName { get; set; }
        public List<Student> Students { get; set; }
    }
}