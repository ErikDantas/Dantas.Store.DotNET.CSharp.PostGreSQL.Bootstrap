using System;

namespace Dantas.Store.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
