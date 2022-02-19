using System;
namespace DaPraIr.API.Entities
{
	public class Foto : Base
	{
        public Foto() : base()
        {

        }
        public String Caminho { get; set; }
        public String Legenda { get; set; }
    }
}

