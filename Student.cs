namespace TECEnrollment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> EnrolledCourses { get; set; }
    }
}
