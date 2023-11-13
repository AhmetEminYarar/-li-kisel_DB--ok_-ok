using Cok_Cok_İliskisel_Db.MainEntity;
using System.ComponentModel.DataAnnotations;

namespace Cok_Cok_İliskisel_Db.Entity
{
    public class SurName
    {
        [Key]
        public int Id { get; set; }

        public string SurNames { get; set; } = string.Empty;

        public int PersonId { get; set; }
        
    }
}
