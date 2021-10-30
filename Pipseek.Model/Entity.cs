using System.ComponentModel.DataAnnotations;

namespace Pipseek.Model
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; } 
    }
}