using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("Ingredientes")]
public class Ingrediente 
{
    [Key]
    public int Id { get; set;}

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

}
