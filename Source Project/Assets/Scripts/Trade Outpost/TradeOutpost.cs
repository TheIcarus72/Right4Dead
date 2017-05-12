using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

public class TradeOutpost : MonoBehaviour {
	private GameObject player;
	public void buyMedicine() 
	{
		//if (GetComponent<Player>().money >= 5){
			
			GetComponent<Player> ().infection--;
		//	player.GetComponent<Player> ().money -= 5;
		//}
	}

	public void buyFood()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		//if (GetComponent<Player>().money >= 1){

		GameManager.instance.playerFoodPoints += 5;
		//GameManager.instance.money--;
		//}
	}
}
