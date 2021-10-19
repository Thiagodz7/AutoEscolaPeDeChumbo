using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Alunos
{
    public class Aluno
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nome do Funcionário")]
        public string funcionario { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [Required]
        [Display(Name = "Idade")]
        public int idade { get; set; }

        [Required]
        [Display(Name = "Saldo")]
        public decimal saldo { get; set; }

        [Required]
        [Display(Name = "Possui CNH?")]
        public bool possuiCNH { get; set; } = false;

    }
}
