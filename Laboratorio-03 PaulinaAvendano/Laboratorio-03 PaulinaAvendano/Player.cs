using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public class Player
    {
        private const int LIFE_POINTS = 2;
        private const int START_ATTACK_POINTS = 0;
        private static int idCounter;

        private int id;
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public Player()
        {
            LifePoints = LIFE_POINTS;
            AttackPoints = START_ATTACK_POINTS;
            Deck = new Deck();
            Hand = new Hand();
            Id = idCounter++;
        }
        public int Id { get => id; set => id = value; }
        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }
        public Board Board
        {
            get
            {
                return this.board;
            }
            set
            {
                this.board = value;
            }
        }
        public SpecialCard Captain
        {
            get
            {
                return this.captain;
            }
            set
            {
                this.captain = value;
            }
        }

        //Metodos
        public void DrawCard()
        {
            throw new NotImplementedException();
        }
        public void PlayCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void ChangeCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void FirstHand()
        {
            throw new NotImplementedException();
        }
        public void ChooseCaptainCard(SpecialCard captainCard)
        {
            throw new NotImplementedException();
        }
    }
}
