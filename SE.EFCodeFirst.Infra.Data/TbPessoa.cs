using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.EFCodeFirst.Infra.Data
{
    [Table("TB_Pessoa")]
    public partial class TbPessoa
    {
        public int Id { get; set; }
        [Column("Pes_nmPessoa")]
        [StringLength(200)]
        public string PesNmPessoa { get; set; }
        [Column("Pes_nrIdade")]
        public int? PesNrIdade { get; set; }
        [Column("Pes_dtCadastro", TypeName = "datetime")]
        public DateTime? PesDtCadastro { get; set; }
        [Column("Pes_flAtivo")]
        public bool? PesFlAtivo { get; set; }
    }
}
