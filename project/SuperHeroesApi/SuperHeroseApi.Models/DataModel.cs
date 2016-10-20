namespace SuperHeroseApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public abstract class DataModel
    {
        [Key]
        public int Id { get; set; }
    }
}
