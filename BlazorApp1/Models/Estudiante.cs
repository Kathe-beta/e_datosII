using Supabase.Postgrest.Atribute;
using Supabaase.Postgrest.Models;
[Table("estudiantes")]
public class Estudiante : BaseModel
{
    [Column("nombre")]

    private string Nombre { get; set; }

    [Column("carrera")]    
    private string Carrera { get; set; }

}