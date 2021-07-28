using System;

namespace JudgeRoller_DLL
{
    public class Roller
    {
        Random Rand = new Random(Guid.NewGuid().GetHashCode());

        public int Roll()
        {
            return Rand.Next(1, 101);
        }

        public int RollD10()
        {
            return Rand.Next(1, 11);
        }
    }
}
