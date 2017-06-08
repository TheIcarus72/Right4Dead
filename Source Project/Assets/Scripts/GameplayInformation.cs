using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Completed
{
    public class GameplayInformation : MonoBehaviour
    {

        public static GameplayInformation instance = null;

        public Text moved;
        public Text food;
        public Text medicine;
        public Text hit;
        public Text trader;
        public Text moneyEarned;
        public Text foodBought;
        public Text medicineBougt;

        int totalMoved;
        int totalFood;
        int totalMedicine;
        int totalHit;
        int totalTrader;
        int totalEarned;
        int totalFoodBought;
        int totalMedicineBought;

        // Use this for initialization
        void Awake()
        {
                        //Check if instance already exists
            if (instance == null)

                //if not, set instance to this
                instance = this;

            //If instance already exists and it's not this:
            else if (instance != this)

                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);	
			
			//Sets this to not be destroyed when reloading scene
			DontDestroyOnLoad(gameObject);

        }

        public void TotalMoved()
        {
            totalMoved++;
            moved.text = "Total times moved: " + totalMoved;
        }

        public void TotalFood()
        {
            totalFood++;
            food.text = "Total food items collected: " + totalFood;
        }

        public void TotalMedicine()
        {
            totalMedicine++;
            medicine.text = "Total medicine items collected: " + totalMedicine;
        }

        public void TotalHit()
        {
            totalHit++;
            hit.text = "Total times hit by enemy: " + totalHit;
        }

        public void TraderVisits()
        {
            totalTrader++;
			trader.text = "Total trader visits: " + (totalTrader / 2);
        }

        public void MoneyEarned()
        {
            totalEarned++;
            moneyEarned.text = "Total money earned: " + totalEarned;
        }

        public void FoodBought()
        {
            totalFoodBought++;
            foodBought.text = "Total food items bought at trader: " + totalFoodBought;
        }

        public void MedicineBought()
        {
            totalMedicineBought++;
			medicineBougt.text = "Total medicine items bought at trader " + totalMedicineBought;
        }

    }
}

