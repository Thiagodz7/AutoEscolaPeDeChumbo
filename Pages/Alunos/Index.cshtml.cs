﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Data;

namespace AutoEscolaPeDeChumbo.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext _context;

        public IndexModel(AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; }

        public async Task OnGetAsync()
        {
            Aluno = await _context.Aluno.ToListAsync();
        }
    }
}
