﻿
namespace FinancialControl.Application.DTOs
{
    public class UsuarioRequestDto
    {
        public string NomeCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
    }
}
