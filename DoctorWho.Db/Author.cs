using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Column("AuthorName")]
        public string Name { get; set; }

        public List<Episode> Episodes { get; set; }

        public Author() {
            Episodes = new List<Episode>();
        }
    }
}