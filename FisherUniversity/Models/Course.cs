using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FisherUniversity.Models
{
    public class Course
    {
        //The next statement lets you enter the primary key for the course rather than having the database generate it.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
