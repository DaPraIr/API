using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaPraIr.API.Entities
{
    public class Local : Base
    {
        public Local() : base()
        {

        }

        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Guid FotoId { get; set; }
        [ForeignKey("FotoId")] public virtual Foto FotoCapa { get; set; }
    }
}