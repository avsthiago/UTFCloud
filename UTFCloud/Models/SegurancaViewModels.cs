﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UTFCloud.Models
{
    public class SegurancaViewModels
    {
        public class LoginViewModel
        {

            [Required]
            public string Nome { get; set; }
            [Required]
            public string Senha { get; set; }
        }

        //public class PapelEditModel
        //{
        //    public Papel Papel { get; set; }
        //    public IEnumerable<Usuario> Membros { get; set; }
        //    public IEnumerable<Usuario> NaoMembros { get; set; }
        //}

        //public class PapelModificationModel
        //{
        //    [Required]
        //    public string NomePapel { get; set; }
        //    public string[] IdsParaAdicionar { get; set; }
        //    public string[] IdsParaRemover { get; set; }
        //}
    }
}