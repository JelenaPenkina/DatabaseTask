using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class AnonymousFeedback
    {

        [Key]
        public int Feedback_ID { get; set; }

        public string Text { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
