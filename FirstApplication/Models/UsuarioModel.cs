using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class UsuarioModel
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
    }
}