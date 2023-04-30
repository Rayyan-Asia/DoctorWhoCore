using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db
{
    public class Companion
    {
        public Companion() {
            Episodes = new List<Episode>();
        }  
        public int CompanionId { get; set; }

        [Column("CompanionName")]
        public string Name { get; set;}

        public string WhoPlayed { get; set;}

        public List<Episode> Episodes { get; set; }
    }
}