using System.ComponentModel.DataAnnotations;

namespace psa_server_dotnetcore.Model
{
    //[Table("users")]
    public class UserData
    {
        [Key]
        public string id { get; set; }
        //[Required]
        public string usuario { get; set; }
        //[Required]
        public string email { get; set; }
        //[Required]
        public string phone { get; set; }
        //[Required]
        public string password { get; set; }
        //[Required]
        public string date { get; set; }
    }
}
