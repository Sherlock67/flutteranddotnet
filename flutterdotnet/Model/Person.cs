using System.ComponentModel.DataAnnotations;

namespace flutterdotnet.Model
{
    public class Person
    {

        [Key]
        public int PersonId { get; set; }

        public string personName { get; set; }

        public int personAge { get; set; }
    }
}
