using System.ComponentModel.DataAnnotations;

namespace eZionBlazor.Contabil.Models;

public class Empresa
{
    public int Id { get; set; }

    [Required]
    [StringLength(120)]
    public string Nome { get; set; } = string.Empty;

    [StringLength(18)]
    public string? Cnpj { get; set; }

    public bool Ativa { get; set; } = true;
}