namespace ChefProject
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();
            
            Peel(potato);
            Peel(carrot);
            
            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private void Peel(Vegetable inputVegetable)
        {
            //...
        }

        private void Cut(Vegetable inputVegetable)
        {
            //...
        }
    }
}
