using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steaks
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string _name;

        public string Name
        {
            get => _name;
        }

        public void SweepStakes(string nameOfStake)
        {
            nameOfStake = _name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            int contestantKey = contestants.Count + 1;
            contestants.Add(contestantKey, contestant);
        }
        public Contestant ContestantPickWinner()
        {
            Random random = new Random();
            int winnerNumber = random.Next(0, contestants.Count);
            Contestant winner = contestants[winnerNumber];
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantWinner(contestant);
        }
    }
}
