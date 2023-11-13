using Cok_Cok_İliskisel_Db.MainEntity;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Cok_Cok_İliskisel_Db.Entity
{
    public class Name
    {
        [Key]
        public int Id { get; set; }

        public string Names { get; set; }=string.Empty;

        public int PersonId { get; set; }
        
    }
}
