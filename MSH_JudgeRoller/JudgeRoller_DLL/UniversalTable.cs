namespace JudgeRoller_DLL
{
    public class UniversalTable
    {
        private Roller rand = new Roller();
        public int RollResult = 0;
        public int CostToGreen = -1;
        public int CostToYellow = -1;
        public int CostToRed = -1;

        public int D10()
        {
            return rand.RollD10();
        }

        public string RollFEAT(string Rank, out int RollResult)
        {
            int num = rand.Roll();
            RollResult = num;
            switch (Rank)
            {
                case "Shift-0":
                    {
                        if (num <= 65)
                        {
                            CostToGreen = 66 - num;
                            CostToYellow = 95 - num;
                            CostToRed = 100 - num;
                            return "WHITE";
                        }
                        else if (num <= 94)
                        {
                            CostToGreen = -1;
                            CostToYellow = 95 - num;
                            CostToRed = 100 - num;
                            return "GREEN";
                        }
                        else if (num <= 99)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 100 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Feeble":
                    {
                        if (num <= 60) 
                        {
                            CostToGreen = 61 - num;
                            CostToYellow = 91 - num;
                            CostToRed = 100 - num;
                            return "WHITE";
                        }
                        else if (num <= 90)
                        {
                            CostToGreen = -1;
                            CostToYellow = 91 - num;
                            CostToRed = 100 - num;
                            return "GREEN";
                        }
                        else if (num <= 99)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 100 - num;
                            return "YELLOW";
                        }                        
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }                        
                    }
                case "Poor":
                    {
                        if (num <= 55)
                        {
                            CostToGreen = 56 - num;
                            CostToYellow = 86 - num;
                            CostToRed = 97 - num;
                            return "WHITE";
                        }
                        else if (num <= 85)
                        {
                            CostToGreen = -1;
                            CostToYellow = 86 - num;
                            CostToRed = 100 - num;
                            return "GREEN";
                        }
                        else if (num <= 97)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 100 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Typical":
                    {
                        if (num <= 50)
                        {
                            CostToGreen = 51 - num;
                            CostToYellow = 81 - num;
                            CostToRed = 98 - num;
                            return "WHITE";
                        }
                        else if (num <= 80)
                        {
                            CostToGreen = -1;
                            CostToYellow = 81 - num;
                            CostToRed = 98 - num;
                            return "GREEN";
                        }
                        else if (num <= 97)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 98 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Good":
                    {
                        if (num <= 45)
                        {
                            CostToGreen = 46 - num;
                            CostToYellow = 76 - num;
                            CostToRed = 98 - num;
                            return "WHITE";
                        }
                        else if (num <= 75)
                        {
                            CostToGreen = -1;
                            CostToYellow = 76 - num;
                            CostToRed = 98 - num;
                            return "GREEN";
                        }
                        else if (num <= 97)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 98 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Excellent":
                    {
                        if (num <= 40)
                        {
                            CostToGreen = 41 - num;
                            CostToYellow = 71 - num;
                            CostToRed = 95 - num;
                            return "WHITE";
                        }
                        else if (num <= 70)
                        {
                            CostToGreen = -1;
                            CostToYellow = 71 - num;
                            CostToRed = 95 - num;
                            return "GREEN";
                        }
                        else if (num <= 94)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 95 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Remarkable":
                    {
                        if (num <= 35)
                        {
                            CostToGreen = 36 - num;
                            CostToYellow = 66 - num;
                            CostToRed = 95 - num;
                            return "WHITE";
                        }
                        else if (num <= 65)
                        {
                            CostToGreen = -1;
                            CostToYellow = 66 - num;
                            CostToRed = 95 - num;
                            return "GREEN";
                        }
                        else if (num <= 94)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 95 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Incredible":
                    {
                        if (num <= 30)
                        {
                            CostToGreen = 31 - num;
                            CostToYellow = 61 - num;
                            CostToRed = 91 - num;
                            return "WHITE";
                        }
                        else if (num <= 60)
                        {
                            CostToGreen = -1;
                            CostToYellow = 61 - num;
                            CostToRed = 91 - num;
                            return "GREEN";
                        }
                        else if (num <= 90)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 91 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Amazing":
                    {
                        if (num <= 25)
                        {
                            CostToGreen = 26 - num;
                            CostToYellow = 56 - num;
                            CostToRed = 91 - num;
                            return "WHITE";
                        }
                        else if (num <= 55)
                        {
                            CostToGreen = -1;
                            CostToYellow = 56 - num;
                            CostToRed = 91 - num;
                            return "GREEN";
                        }
                        else if (num <= 90)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 91 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Monstrous":
                    {
                        if (num <= 20)
                        {
                            CostToGreen = 21 - num;
                            CostToYellow = 51 - num;
                            CostToRed = 86 - num;
                            return "WHITE";
                        }
                        else if (num <= 50)
                        {
                            CostToGreen = -1;
                            CostToYellow = 51 - num;
                            CostToRed = 86 - num;
                            return "GREEN";
                        }
                        else if (num <= 99)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 86 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Unearthly":
                    {
                        if (num <= 15)
                        {
                            CostToGreen = 16 - num;
                            CostToYellow = 46 - num;
                            CostToRed = 86 - num;
                            return "WHITE";
                        }
                        else if (num <= 45)
                        {
                            CostToGreen = -1;
                            CostToYellow = 46 - num;
                            CostToRed = 86 - num;
                            return "GREEN";
                        }
                        else if (num <= 85)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 86 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Shift-X":
                    {
                        if (num <= 10)
                        {
                            CostToGreen = 11 - num;
                            CostToYellow = 41 - num;
                            CostToRed = 81 - num;
                            return "WHITE";
                        }
                        else if (num <= 40)
                        {
                            CostToGreen = -1;
                            CostToYellow = 41 - num;
                            CostToRed = 81 - num;
                            return "GREEN";
                        }
                        else if (num <= 80)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 81 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Shift-Y":
                    {
                        if (num <= 6)
                        {
                            CostToGreen = 7 - num;
                            CostToYellow = 41 - num;
                            CostToRed = 81 - num;
                            return "WHITE";
                        }
                        else if (num <= 40)
                        {
                            CostToGreen = -1;
                            CostToYellow = 41 - num;
                            CostToRed = 81 - num;
                            return "GREEN";
                        }
                        else if (num <= 80)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 81 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Shift-Z":
                    {
                        if (num <= 3)
                        {
                            CostToGreen = 4 - num;
                            CostToYellow = 36 - num;
                            CostToRed = 100 - num;
                            return "WHITE";
                        }
                        else if (num <= 35)
                        {
                            CostToGreen = -1;
                            CostToYellow = 36 - num;
                            CostToRed = 76 - num;
                            return "GREEN";
                        }
                        else if (num <= 75)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 76 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Class-1000":
                    {
                        if (num <= 1)
                        {
                            CostToGreen = 2 - num;
                            CostToYellow = 36 - num;
                            CostToRed = 76 - num;
                            return "WHITE";
                        }
                        else if (num <= 35)
                        {
                            CostToGreen = -1;
                            CostToYellow = 36 - num;
                            CostToRed = 76 - num;
                            return "GREEN";
                        }
                        else if (num <= 75)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 76 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Class-3000":
                    {
                        if (num <= 1)
                        {
                            CostToGreen = 2 - num;
                            CostToYellow = 31 - num;
                            CostToRed = 71 - num;
                            return "WHITE";
                        }
                        else if (num <= 30)
                        {
                            CostToGreen = -1;
                            CostToYellow = 31 - num;
                            CostToRed = 71 - num;
                            return "GREEN";
                        }
                        else if (num <= 70)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 71 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Class-5000":
                    {
                        if (num <= 1)
                        {
                            CostToGreen = 2 - num;
                            CostToYellow = 26 - num;
                            CostToRed = 67 - num;
                            return "WHITE";
                        }
                        else if (num <= 25)
                        {
                            CostToGreen = -1;
                            CostToYellow = 26 - num;
                            CostToRed = 67 - num;
                            return "GREEN";
                        }
                        else if (num <= 65)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 67 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                case "Beyond":
                    {
                        if (num <= 1)
                        {
                            CostToGreen = 2 - num;
                            CostToYellow = 21 - num;
                            CostToRed = 61 - num;
                            return "WHITE";
                        }
                        else if (num <= 20)
                        {
                            CostToGreen = -1;
                            CostToYellow = 21 - num;
                            CostToRed = 61 - num;
                            return "GREEN";
                        }
                        else if (num <= 60)
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = 61 - num;
                            return "YELLOW";
                        }
                        else
                        {
                            CostToGreen = -1;
                            CostToYellow = -1;
                            CostToRed = -1;
                            return "RED";
                        }
                    }
                default:
                    {
                        return "WHITE";
                    }
            }
        }
    }
}
