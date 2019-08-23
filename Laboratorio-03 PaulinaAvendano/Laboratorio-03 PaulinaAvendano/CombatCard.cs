using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class CombatCard : Card
    {
        private int attackPoints;
        private bool hero;

        public CombatCard(string name, string type, string effect, int attackPoints, bool hero) : base(name, type, effect)
        {
            AttackPoints = attackPoints;
            Hero = hero;
        }

        public int AttackPoints { get => attackPoints; set => AttackPoints = attackPoints; }

        public bool Hero { get => hero; set => Hero = hero; }
    }
}
