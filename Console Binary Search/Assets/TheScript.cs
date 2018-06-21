using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScript : MonoBehaviour {

	private int Min = 1;
	private int Max = 500;

	// Use this for initialization
	void Start () 
		{
			Debug.Log("Welcome! To the Guessing game!");
			Debug.Log("Think of a number between [ 1 to 500 ] but don't tell me");
			Debug.Log("I will try to guess your number");
			Debug.Log("=========================================");			
			GenerateNumber();
		}
	
	// Update is called once per frame
	void Update () 
		{
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				Min = Answer();
				GenerateNumber();
			}

			if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				Max = Answer();
				GenerateNumber();
			}

			if(Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("Hurray!I guessed your number!");
			}
		}

			int Answer()
			{
				return(Max+Min)/2;
			}

	 void GenerateNumber()
		{
			int answer = Answer();
			Debug.Log("Press the UP Arrow key if your number is Higher || DOWN Arrow key if your number is Lower");			
			Debug.Log("If I guessed your number Press the Spacebar Key\n");
			Debug.Log("Is "+answer+" The number?" );			
		}
}
