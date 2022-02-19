using System;
using System.ComponentModel.DataAnnotations;

namespace DaPraIr.API.Entities
{
	public class Base
	{
        public Base()
        {
            Id = new Guid();
        }

        [Key]
        public Guid Id { get; set; }

        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public bool Moderado { get; set; }
        public bool Deletado { get; set; }
    }
}

