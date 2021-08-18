using System;
using System.ComponentModel.DataAnnotations;

namespace DemoWsTemplateV1.Models
{
    public class ConsultaCep
    {
        [Required]
        [StringLength(100)]
        public string Logradouro { get; set; }
        [Required]
        [StringLength(30)]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        [RegularExpression (@"^[A-Z]{2}$")]
        public string Estado { get; set; }
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter 8 dígitos")]
        public string Cep { get; set; }

    }

    // public override string ToString()
    // 
    //     return "oi"; 
    //  
}