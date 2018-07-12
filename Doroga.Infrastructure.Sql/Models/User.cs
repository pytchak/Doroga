﻿using System;

namespace Doroga.Infrastructure.Sql.Models
{
    class User
    {
        public string Id { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTimeOffset? Birthday { get; set; }

        public string Comment { get; set; }

        public bool IsDeleted { get; set; }

        // Need Add Address and Model of Car 
       
    }
}
