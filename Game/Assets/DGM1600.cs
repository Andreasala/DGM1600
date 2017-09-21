using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DGM1600 : MonoBehaviour {

	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;


	// Use this for initialization
	void Start ()
	{
		guess = Random.Range(min, max);



		textBox.text = "Welcome to Number Guesser "
		+ "\npick a number in your head"
		+ "\n\nThe Highest number you can pick is " + max
		+ "\nThe lowest number you can pick is " + min
		+ "\n\nIs the number higher or lower than " + guess
		+ "\nUp arrow for higher, Down for lower, Enter for equal";
		  


		print ("Welcome To Number Guesser");
		print ("Pick a number in your head");

		print ("The Highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, Down for lower, Enter for equal");
		max = max + 1;
	}
	    // Update is called once per frame 
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
			
		if (counter == -1) 
		{
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) 
			{
				//counter--;
				print ("I Win!");
				textBox.text = "\n I Win!";
			}
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			print ("is the number higher or lower than" + guess);
			textBox.text = "is the number higher or lower than " + guess;
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) /2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "is the number higer or lower than " + guess;
		}
	    if (Input.GetKeyUp (KeyCode.Return)) 
		{
			print ("You Win, I lose");
			textBox.text = "You Win, I lose";
	    }

		if (counter == 0)
		{ 
			counter--;
		}
	}
}
				