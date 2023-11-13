using Cok_Cok_İliskisel_Db.Entity;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Cok_Cok_İliskisel_Db.MainEntity
{
    public class Person
    {
        [Key] 
        public int Id { get; set; }

        public string Name{ get; set; } = string.Empty;
        public ICollection<Name> names { get; set; } = new List<Name>();

        public string SurName { get; set; } = string.Empty;
        public ICollection<SurName> Surnames { get; set; } = new List<SurName>();

        public int Age { get; set;}
        public ICollection<Age> Ages { get; set; } = new List<Age>();


    }
}
