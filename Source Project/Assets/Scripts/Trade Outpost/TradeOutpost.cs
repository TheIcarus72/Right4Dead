using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

public class TradeOutpost : MonoBehaviour {
	private GameObject player;
	public GameObject tradeCanvas;
	public void buyMedicine() 
	{
		if (GameManager.instance.money >= 5){
			
			GetComponent<Player> ().infection--;
			GameManager.instance.money -= 5;
		}
	}

	public void buyFood()
	{
		if (GameManager.instance.money >= 1){

		GameManager.instance.playerFoodPoints += 5;
		GameManager.instance.money--;
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
