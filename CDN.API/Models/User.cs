using System.ComponentModel.DataAnnotations;

namespace CDN.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public String Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        public String Skillsets { get; set; }

        public String Hobby { get; set; }

    }
}
