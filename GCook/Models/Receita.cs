using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("receita")]
public class Receita
{
    [Key]
    public int Id { get; set; }
}
