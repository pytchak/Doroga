using System;
using System.Collections.Generic;
using System.Text;

namespace DorogaUa.Domain.Models.Entities
{
    public class ArticelEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfCreated { get; set; }

        public string MainContent { get; set; }

        public string LinkSource { get; set; }

        // Need Add Reviews
    }
}
