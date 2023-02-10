namespace TECEnrollment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> EnrolledCourses { get; set; }
    }
}
