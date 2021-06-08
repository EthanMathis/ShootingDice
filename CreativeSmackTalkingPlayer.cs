using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> TauntList { get; set; } = new List<string>()
        {
            "You're trash!", "I'm the best! I can't be beaten", "I've never seen someone roll as bad as you!", "You should just quit now while you still have your dignity..."
        };

        public override int Roll()
        {
            int RandomNumber = new Random().Next(3);
            Console.WriteLine($"{Name} says: {TauntList[RandomNumber]}");
            return base.Roll();
        }
    }
}