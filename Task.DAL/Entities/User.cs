using System;
using System.Collections.Generic;
using System.Text;

namespace Task.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
    }
}
