using System;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Utilities;

namespace DaPraIr.API.Entities
{
    public class ComentarioLocal
    {
        public Guid ComentarioId { get; set; }
        [ForeignKey("ComentarioId")] public Comentario Comentario { get; set; }

        public Guid LocalId { get; set; }
        [ForeignKey("LocalId")] public virtual Local Local { get; set; }

    }
}

