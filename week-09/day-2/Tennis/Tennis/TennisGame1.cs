﻿using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        //private int m_score1 = 0;
        //private int m_score2 = 0;
        //private string player1Name;
        //private string player2Name;
        private Player player1;
        private Player player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            //this.player1Name = player1Name;
            //this.player2Name = player2Name;
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                player1.Score += 1;
            else
                player2.Score += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (player1.Score == player2.Score)
            {
                switch (player1.Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (player1.Score >= 4 || player2.Score >= 4)
            {
                var minusResult = player1.Score - player2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = player1.Score;
                    else { score += "-"; tempScore = player2.Score; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}
