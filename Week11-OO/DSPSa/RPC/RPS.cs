using System;

namespace RPS
{
    public enum Move
    {
        rock = 0,
        paper = 1,
        scissors = 2
    }

    public class RPS
    {
        public Move Myself {get; set;}
        public Move Computer {get; set;}
        private Random r;
        public int MyScore {get; set;}
        public int ComputerScore {get; set;}

        public RPS()
        {
            r = new Random();
        }

        public string Choice()
        {
            Computer = (Move)r.Next(0, 3);

            string result = "";
            //if I win
            if ((Myself == Move.paper && Computer == Move.rock) || (Myself == Move.rock && Computer == Move.scissors) 
            || (Myself == Move.scissors && Computer == Move.paper))
            {
                MyScore++;
                result = $"Computer had: {Computer} --> I win!";
            }
            else if((Computer == Move.paper && Myself == Move.rock) || (Computer == Move.rock && Myself == Move.scissors) 
            || (Computer == Move.scissors && Myself == Move.paper))
            {
                ComputerScore++;
                result = $"Computer had: {Computer} --> I lose :'(!";
            }
            else
            {
                result = $"Computer had: {Computer} --> EQUAL!";
            }
            return result;
        }

        public override string ToString()
        {
            return $"ME: {MyScore} - {ComputerScore} :Computer";
        }
    }
}