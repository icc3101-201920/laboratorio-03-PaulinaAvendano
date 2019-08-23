using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class Hand
    {
        public Hand() : base()
        {

        }

        public List<CombatCard> CombatCards { get => CombatCards; set => CombatCards = value; }
        public List<SpecialCard> SpecialCards { get => SpecialCards; set => SpecialCards = value; }
    }
}
