using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.NpgsqlEF.Entities
{
	[Table("members")]
	public class Member
	{
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(32),Column("name")]
        public string Name { get; set; }

		[StringLength(50), Column("email")]
		public string Email { get; set; }
	}
}
