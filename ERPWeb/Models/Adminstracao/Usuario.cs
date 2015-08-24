using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERPWeb.Models.Adminstracao
{
    public class Usuario
    {
        public int ID { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "NomeObrigatorio",
                    AllowEmptyStrings = false)]
        [StringLength(300)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "UsuarioObrigatorio",
                    AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),
                    ErrorMessageResourceName = "SenhaObrigatoria",
                    AllowEmptyStrings = false)]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [EmailAddress(ErrorMessage="Informe um e-mail válido")]
        [Display(Name="E-mail")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}