using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace eZionBlazor.Contabil.Models;

public class Empresa : IValidatableObject
{
    public int Id { get; set; }

    [Required]
    [StringLength(120)]
    public string RazaoSocial { get; set; } = string.Empty;

    [StringLength(18)]
    public string? Cnpj { get; set; }

    public bool Ativa { get; set; } = true;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(Cnpj)) yield break;
        var digits = new string(Cnpj.Where(char.IsDigit).ToArray());
        if (digits.Length != 14) { yield return new ValidationResult("CNPJ inválido", new[] { nameof(Cnpj) }); yield break; }
        if (digits.Distinct().Count() == 1) { yield return new ValidationResult("CNPJ inválido", new[] { nameof(Cnpj) }); yield break; }
        int[] w1 = new[] {5,4,3,2,9,8,7,6,5,4,3,2};
        int[] w2 = new[] {6,5,4,3,2,9,8,7,6,5,4,3,2};
        int sum1 = 0; for (int i = 0; i < 12; i++) sum1 += (digits[i]-'0') * w1[i];
        int r1 = sum1 % 11; int d1 = r1 < 2 ? 0 : 11 - r1;
        int sum2 = 0; for (int i = 0; i < 13; i++) sum2 += (digits[i]-'0') * w2[i];
        int r2 = sum2 % 11; int d2 = r2 < 2 ? 0 : 11 - r2;
        if ((digits[12]-'0') != d1 || (digits[13]-'0') != d2) { yield return new ValidationResult("CNPJ inválido", new[] { nameof(Cnpj) }); }
    }
}