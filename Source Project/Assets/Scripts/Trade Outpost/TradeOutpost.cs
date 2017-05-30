using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

public class TradeOutpost : MonoBehaviour {
    public Player player;
	public GameObject tradeCanvas;
	public void buyMedicine() 
	{
		if (player.money >= 10){

            player.infection--;
            player.infectionText.text = "Infection: " + player.infection;
            player.money -= 10;
            player.moneyText.text = "Money: " + player.money;

            //GetComponent<Player> ().infection--;
            //GameManager.instance.money -= 5;
        }
	}

	public void buyFood()
	{
		if (player.money >= 5){

            player.food++;
            player.foodText.text = "Food: " + player.food;
            player.money -=5;
            player.moneyText.text = "Money: " + player.money;
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
