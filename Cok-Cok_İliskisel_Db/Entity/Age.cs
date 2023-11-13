using Cok_Cok_İliskisel_Db.MainEntity;
using System.ComponentModel.DataAnnotations;

namespace Cok_Cok_İliskisel_Db.Entity
{
    public class Age
    {
        [Key]
        public int Id { get; set; }

        public int Ages { get; set; } 

        public int PersonId { get; set; }
        
    }
}
