using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballSimulator
{
    class BaseballSimulator
    {
        private int currentInning;
        private int totalHomeScore;
        private int totalAwayScore;
        private int currentOuts;
        private int[] home;
        private int[] away;
        private string halfInningPlays;
        private bool[] bases = new bool[4];
        private int[] possiblePlays = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 3, 3, 4 };
        bool homeTurn;
        bool awayTurn;
        private bool gameOver;
        private int currentInningScore;

        public void NewGame()
        {
            homeTurn = true;
            awayTurn = false;
            halfInningPlays = "";
            totalHomeScore = 0;
            totalAwayScore = 0;
            currentInning = 1;
            gameOver = false;
            home = new int[9];
            away = new int[9];
        }

        public int getHomeScore()
        {
            return totalHomeScore;
        }

        public int[] HomeInningsScore(){
            return home;
        }

        public int[] AwayInningsScore(){
            return away;
        }

        public bool getGameStatus()
        {
            return gameOver;
        }
        
        public string getCurrentInning()
        {
            if (!gameOver)
            {
                if (homeTurn)
                {
                    return "Top of " + currentInning;
                }
                else { return "Bot. of " + currentInning; }
            }
            else { return "Over"; }
        }

        public string getInningPlays()
        {
            return halfInningPlays;
        }

        public int getAwayScore()
        {
            return totalAwayScore;
        }
        
        public void UpdateBases(int baseHit)
        {
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("Cell "+i +" " +bases[i]+"\n");
                //bases[3] = home
                //bases[2] = third
                //bases[1] = second
                //bases[0] = first
                if (bases[i] == true && i == baseHit)
                {
                    bases[i+1] = true;
                    CheckRuns();
                }
                else if (bases[i] == true && i < baseHit)
                {
                    bases[i] = false;
                    int newbase = 1 + baseHit;
                    if (newbase > 3)
                    {
                        newbase = 3;
                    }
                    bases[newbase] = true;
                    CheckRuns();
                }
            }
            bases[baseHit] = true;
            CheckRuns();
        }
        public void CheckRuns()
        {
            if (bases[3] == true)
            {
                if (homeTurn)
                {
                    totalHomeScore++;
                    currentInningScore++;
                }
                else 
                { 
                    totalAwayScore++;
                    currentInningScore++;
                }
                bases[3] = false;
            }
        }

        public void HalfInning()
        {
            currentOuts = 0;
            currentInningScore = 0;
            int play;
            //halfInningPlays = "";
            bases[0] = false;
            bases[1] = false;
            bases[2] = false;
            bases[3] = false;
            string outcome;
            Random random = new Random();
            while (currentOuts < 3)
            {
                play = possiblePlays[random.Next(0, possiblePlays.Length)];
                Console.Write(play);
                if (play == 0)
                {
                    outcome = "Out. ";
                    currentOuts++;
                    halfInningPlays += outcome;
                }
                else if (play == 1)
                {
                    outcome = "Single. ";
                    UpdateBases(0);
                    halfInningPlays += outcome;
                }
                else if (play == 2)
                {
                    outcome = "Double. ";
                    UpdateBases(1);
                    halfInningPlays += outcome;
                }
                else if (play == 3)
                {
                    outcome = "Triple. ";
                    UpdateBases(2);
                    halfInningPlays += outcome;
                }
                else
                {
                    outcome = "Homerun!! ";
                    UpdateBases(3);
                    halfInningPlays += outcome;
                }

            }
            if (homeTurn == true && currentOuts == 3)
            {
                homeTurn = false;
                awayTurn = true;
                home[currentInning - 1] = currentInningScore;
                halfInningPlays += "\n";
            }
            else if (homeTurn == false && currentOuts == 3)
            {
                homeTurn = true;
                awayTurn = false;
                away[currentInning - 1] = currentInningScore;
                halfInningPlays += "\n";
                if (currentInning < 9) { currentInning++; }
            }
            GameStatus();
        }

        public void GameStatus()
        {
            if (currentInning == 9 && awayTurn == true)
            {
                HalfInning();
                gameOver = true;
            }
            else { gameOver = false; }
        }

        public void FullGame()
        {
            for (int i = 0; i < 18; i++)
            {
                HalfInning();
                //Added since method was running to fast and not
                //creating new data
                System.Threading.Thread.Sleep(25);
            }
        }
        public void SingleInning()
        {
            for (int i = 0; i < 2; i++)
            {
                HalfInning();
                //Added since method was running to fast and not
                //creating new data
                System.Threading.Thread.Sleep(25);
            }
        }
    }
}
