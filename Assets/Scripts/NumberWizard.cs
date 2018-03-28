using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {


    // Use this for initialization
    int max;
    int min;
    int guess;
	void Start () {

        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        


        print("==========================================");
        print("Welcome to number wizard");
        print("Pick a number in your head, and dont tell me!");
        print("Is the number higher or lower than" + guess);
        print("Up arrow for higher, down for lower, return for qual");

        max = max + 1;
        
    }

	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();

        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
		
	}

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than" + guess);
        print("Up arrow for higher, down for lower, return for qual");
    }
}
