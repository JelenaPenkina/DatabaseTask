using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class AnonymousFeedback
    {

        [Key]
        public int FeedbackId { get; set; }

        public string Text { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
