using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            Cards = cards;
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCombatCard(CombatCard combatCard)
        {
            cards.Add(combatCard);
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
            cards.Add(specialCard);
        }
        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
