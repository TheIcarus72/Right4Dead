using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

public class TradeOutpost : MonoBehaviour {
    public Player player;
	public GameObject tradeCanvas;
    private GameplayInformation gamePlayInfo;

    public void Start()
    {
        gamePlayInfo = GameObject.Find("GamePlayInfo").GetComponent<GameplayInformation>();
    }
    public void buyMedicine() 
	{
		if (player.money >= 10){

            player.infection--;
            gamePlayInfo.MedicineBought();
            player.infectionText.text = "Infection: " + player.infection;
            player.money -= 10;
            player.moneyText.text = "Money: " + player.money;
        }
	}

	public void buyFood()
	{
		if (player.money >= 5){

            player.food+=2;
            
            player.foodText.text = "Food: " + player.food;
            player.money -=5;
            player.moneyText.text = "Money: " + player.money;
            gamePlayInfo.FoodBought();
        }
	}

	public void Close()
	{
		tradeCanvas.SetActive (false);
	}

	public void Open()
	{
		tradeCanvas.SetActive (true);
	}
}
