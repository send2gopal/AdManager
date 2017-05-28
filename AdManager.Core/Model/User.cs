using System;
public class User
{

        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public int LoginFailedCount { get; set; }
      
}
