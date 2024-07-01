using StroyMarket.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StroyMarket.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public Roles role { get; set; }
        public string password { get; set; }
        public bool verified { get; set; }
        public int? verification_code { get; set; }
    }
}
