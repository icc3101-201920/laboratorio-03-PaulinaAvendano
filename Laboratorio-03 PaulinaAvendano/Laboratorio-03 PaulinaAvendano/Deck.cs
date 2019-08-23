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

        public void AddCombatCard(CombatCard combatCard) { throw new NotImplementedException(); }
        public void AddSpecialCard(SpecialCard specialCard) { throw new NotImplementedException(); }
        public void DestroyCombatCard(int cardId) { throw new NotImplementedException(); }
        public void DestroySpecialCard(int cardId) { throw new NotImplementedException(); }
        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
