using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoEscolaPeDeChumbo.Pages.Alunos;

namespace AutoEscolaPeDeChumbo.Pages.Funcionarios
{
    public class Funcionario
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
        [Display(Name = "Dependentes")]
        public int dependentes { get; set; }

        [Required]
        [Display(Name = "Salário Bruto")]
        public decimal salBruto { get; set; }

        [Required]
        [Display(Name = "Cargo")]
        public string cargo { get; set; }
    }

}
