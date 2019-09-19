using System.Collections.Generic;

namespace BookReview.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<Read> Books { get; set; }

        public ICollection<Chapter> Chapters{ get; set; }
    }
}