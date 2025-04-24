namespace Assignment.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public double HourRate { get; set; }
        public virtual Department? ManagedDepartment { get; set; }
        public virtual Department WorkingDepartment { get; set; }
        public int? WorkingDepartmentId { get; set; }
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    }
}
