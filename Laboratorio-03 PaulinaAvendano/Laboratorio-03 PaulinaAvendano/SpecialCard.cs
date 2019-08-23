using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;

        //Constructor
        public SpecialCard(string name, string type, string effect, string buffType) : base(name, type, effect)
        {
            BuffType = null;
        }

        //Propiedades
        public string BuffType { get => buffType; set => BuffType = value; }
    }
}
