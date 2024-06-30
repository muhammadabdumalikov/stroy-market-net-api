using MohirdevNet.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MohirdevNet.Model
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name_uz { get; set; }
        public string name_ru { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }

    }
}
