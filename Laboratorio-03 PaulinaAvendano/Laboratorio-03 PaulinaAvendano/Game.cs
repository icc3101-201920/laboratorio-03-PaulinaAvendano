using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_03_PaulinaAvendano
{
    public abstract class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }

        public Player[] Players { get => players; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public Board BoardGame { get => boardGame; }
        public bool EndGame { get => endGame; set => endGame = value; }

        public bool CheckIfEndGame()
        {
            throw new NotImplementedException();
        }
        public bool GetWinner()
        {
            throw new NotImplementedException();
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
