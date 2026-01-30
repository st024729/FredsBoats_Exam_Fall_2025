using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [Column("Comment ID")]
        public int CommentId { get; set; }

        [Column("Content")]
        [StringLength(250)]
        public string Content { get; set; } = string.Empty;

        [Column("Author")]
        [StringLength(50)]
        public string Author { get; set; } = string.Empty;

        [Column("Date Posted")]
        public DateTime CreatedAt { get; set; }

        [Column("fkboatid")]
        public int BoatId { get; set; }
        
        [ForeignKey("BoatId")]
        public Boat? Boat { get; set; }
        
        [NotMapped]
        public ICollection<Boat> Boats { get; set; } = new List<Boat>();
    }
}