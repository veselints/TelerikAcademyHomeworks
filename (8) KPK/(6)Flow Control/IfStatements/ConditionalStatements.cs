namespace IfStatements
{
    using System;

    class ConditionalStatements
    {
        static void FirstConditional()
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            
        }

        static void SecondConditional(double x, double y)
        {
            if (ValidateX(x) && ValidateY(y) && canVisitCell)
            {
               VisitCell();
            }
        }

        private bool ValidateX(double x)
        {
            if (x >= MIN_X && x <= MAX_X)
            {
                return true;
            }

            return false;
        }

        private bool ValidateY(double y)
        {
            if (y >= MIN_Y && y <= MAX_Y)
            {
                return true;
            }

            return false;
        }
    }
}
