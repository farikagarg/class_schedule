using System.ComponentModel.DataAnnotations;

namespace ClassTest.Models
{
    public class ClassSchedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Availability { get; set; }
       // public int MyProperty { get; set; }
    }
}
