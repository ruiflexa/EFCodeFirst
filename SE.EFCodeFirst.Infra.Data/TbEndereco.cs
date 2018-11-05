using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.EFCodeFirst.Infra.Data
{
    [Table("TB_Endereco")]
    public partial class TbEndereco
    {
        public int Id { get; set; }
        [Column("End_nrEndereco")]
        [StringLength(10)]
        public string EndNrEndereco { get; set; }
        [Column("End_dsLogradouro")]
        [StringLength(200)]
        public string EndDsLogradouro { get; set; }
        [Column("End_dsBairro")]
        [StringLength(50)]
        public string EndDsBairro { get; set; }
    }
}
