using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Keyless]
[Table("tb_seguidor")]
public partial class TbSeguidor
{
    [Column("id_seguir")]
    public int IdSeguir { get; set; }

    [Column("id_seguidor")]
    public int IdSeguidor { get; set; }
}
