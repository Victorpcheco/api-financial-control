using FinancialControl.Domain.Enums;

namespace FinancialControl.Application.DTOs;

public class CategoriaRequestDto
{
    public string Nome { get; set; } = string.Empty;
    public TipoCategoria Tipo { get; set; }
}