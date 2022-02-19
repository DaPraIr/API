using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaPraIr.API.Entities
{
	public class FotoLocal
	{
        public Guid FotoId { get; set; }
        [ForeignKey("FotoId")] public virtual Foto Foto { get; set; }

        public Guid LocalId { get; set; }
        [ForeignKey("LocalId")] public Local Local { get; set; }
    }
}

