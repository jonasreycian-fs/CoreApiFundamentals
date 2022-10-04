using System.ComponentModel.DataAnnotations;

namespace CoreCodeCamp.Data
{
    public class Talk
    {
        [Key]
        public int TalkId { get; set; }
        [Required]
        public Camp? Camp { get; set; }
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public int Level { get; set; }
        public Speaker? Speaker { get; set; }
    }
}