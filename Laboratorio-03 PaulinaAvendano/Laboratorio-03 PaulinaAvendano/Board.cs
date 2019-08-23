using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        
        private List<SpecialCard> weatherCards;
        private Dictionary<string, List<Card>>[] playerCards;
        //Propiedades
        public List<SpecialCard> WeatherCards { get => weatherCards; }


        public Board()
        {
            this.weatherCards = new List<SpecialCard>();
            this.playerCards = new Dictionary<string, List<Card>>[DEFAULT_NUMBER_OF_PLAYERS];
            this.playerCards[0] = new Dictionary<string, List<Card>>();
            this.playerCards[1] = new Dictionary<string, List<Card>>();
        }


        public void AddCombatCard(Player player, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(SpecialCard specialCard, Player player, string buffType)
        {
            throw new NotImplementedException();
        }
        public void DestroyCards()
        {
            List<Card>[] captainCards = new List<Card>[DEFAULT_NUMBER_OF_PLAYERS]
            {
                new List<Card>(playerCards[0]["captain"]),
                new List<Card>(playerCards[1]["captain"])
            };
        }
        public int[] GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }

        public void AddCard(Card card, int playerId = -1, string buffType = null)
        {
            if (card.GetType().Name == nameof(CombatCard))
            {
                if (playerId==0 || playerId == 1)
                {
                    if (playerCards[playerId].ContainsKey(card.Type))
                    {
                        playerCards[playerId][card.Type].Add(card);
                    }
                    else
                    {
                        playerCards[playerId].Add(card.Type, new List<Card>() { card });
                    }

                } else
                {
                    throw new IndexOutOfRangeException("No player id given");
                }
            }
            else
            {
                //fjsdlfs
            }
        }
    }
}
