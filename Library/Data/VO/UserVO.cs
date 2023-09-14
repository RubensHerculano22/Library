using System;

namespace Library.Model
{
    public class UserVO
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Active { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
