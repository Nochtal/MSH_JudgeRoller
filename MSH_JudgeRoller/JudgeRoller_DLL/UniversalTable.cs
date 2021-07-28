namespace JudgeRoller_DLL
{
    public class UniversalTable
    {
        private Roller rand = new Roller();

        public int D10()
        {
            return rand.RollD10();
        }

        public string RollFEAT(string Rank)
        {
            int num = rand.Roll();
            switch (Rank)
            {
                case "Shift-0":
                    {
                        if (num <= 65) return "WHITE";
                        else if (num <= 94) return "GREEN";
                        else if (num <= 99) return "YELLOW";
                        else return "RED";
                    }
                case "Feeble":
                    {
                        if (num <= 60) return "WHITE";
                        else if (num <= 90) return "GREEN";
                        else if (num <= 99) return "YELLOW";
                        else return "RED";
                    }
                case "Poor":
                    {
                        if (num <= 55) return "WHITE";
                        else if (num <= 85) return "GREEN";
                        else if (num <= 99) return "YELLOW";
                        else return "RED";
                    }
                case "Typical":
                    {
                        if (num <= 50) return "WHITE";
                        else if (num <= 80) return "GREEN";
                        else if (num <= 97) return "YELLOW";
                        else return "RED";
                    }
                case "Good":
                    {
                        if (num <= 45) return "WHITE";
                        else if (num <= 75) return "GREEN";
                        else if (num <= 97) return "YELLOW";
                        else return "RED";
                    }
                case "Excellent":
                    {
                        if (num <= 40) return "WHITE";
                        else if (num <= 70) return "GREEN";
                        else if (num <= 94) return "YELLOW";
                        else return "RED";
                    }
                case "Remarkable":
                    {
                        if (num <= 35) return "WHITE";
                        else if (num <= 65) return "GREEN";
                        else if (num <= 94) return "YELLOW";
                        else return "RED";
                    }
                case "Incredible":
                    {
                        if (num <= 30) return "WHITE";
                        else if (num <= 60) return "GREEN";
                        else if (num <= 90) return "YELLOW";
                        else return "RED";
                    }
                case "Amazing":
                    {
                        if (num <= 25) return "WHITE";
                        else if (num <= 55) return "GREEN";
                        else if (num <= 90) return "YELLOW";
                        else return "RED";
                    }
                case "Monstrous":
                    {
                        if (num <= 20) return "WHITE";
                        else if (num <= 50) return "GREEN";
                        else if (num <= 85) return "YELLOW";
                        else return "RED";
                    }
                case "Unearthly":
                    {
                        if (num <= 15) return "WHITE";
                        else if (num <= 45) return "GREEN";
                        else if (num <= 85) return "YELLOW";
                        else return "RED";
                    }
                case "Shift-X":
                    {
                        if (num <= 10) return "WHITE";
                        else if (num <= 40) return "GREEN";
                        else if (num <= 80) return "YELLOW";
                        else return "RED";
                    }
                case "Shift-Y":
                    {
                        if (num <= 6) return "WHITE";
                        else if (num <= 40) return "GREEN";
                        else if (num <= 80) return "YELLOW";
                        else return "RED";
                    }
                case "Shift-Z":
                    {
                        if (num <= 3) return "WHITE";
                        else if (num <= 35) return "GREEN";
                        else if (num <= 75) return "YELLOW";
                        else return "RED";
                    }
                case "Class-1000":
                    {
                        if (num <= 1) return "WHITE";
                        else if (num <= 35) return "GREEN";
                        else if (num <= 75) return "YELLOW";
                        else return "RED";
                    }
                case "Class-3000":
                    {
                        if (num <= 1) return "WHITE";
                        else if (num <= 30) return "GREEN";
                        else if (num <= 70) return "YELLOW";
                        else return "RED";
                    }
                case "Class-5000":
                    {
                        if (num <= 1) return "WHITE";
                        else if (num <= 25) return "GREEN";
                        else if (num <= 65) return "YELLOW";
                        else return "RED";
                    }
                case "Beyond":
                    {
                        if (num <= 1) return "WHITE";
                        else if (num <= 20) return "GREEN";
                        else if (num <= 60) return "YELLOW";
                        else return "RED";
                    }
                default:
                    {
                        return "WHITE";
                    }
            }
        }
    }
}
