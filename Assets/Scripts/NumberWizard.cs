using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	public int max;
	public int min;
	public int guess;
	public int maxGuessAllowed=10;
	public int guessCoin;
	public Text text;
	public Text guessNumberText;

	// Use this for initialization
	void Start () {
		/*
		Problem: I can not passing the value if i use
		max=1000;
		min=1;
		guess=setGuess(max,min,guess);
		in showInfo().
		I have to call them in Start().
		*/
		startGame();
	}

	public void startGame(){
		max=1000;
		min=1;
		setGuessCoin(this.maxGuessAllowed);
		//guessCoin=maxGuessAllowed;

		calculate(this);
	}

	public int setGuessCoin(int setGuessCoin){
		this.guessCoin=setGuessCoin;
		return setGuessCoin;
	}

	int setGuess (NumberWizard number)
	{
		guessCoin = guessCoin - 1;
		guessNumberText.text=guessCoin.ToString();
		int period = number.max - number.min;
		int result;
	
		int ra = Random.Range (-(period/50), (period/50));
		Debug.Log(ra);
		result = (number.max+number.min)/2+ra;

		return result;
	}

	public void higher (){
		max=guess;
		calculate(this);
	}

	public void lower (){
		min=guess;
		calculate(this);
	} 

	void calculate (NumberWizard number)
	{
		if (number.guessCoin > 0) {
			number.guess = setGuess (number);
			number.text.text=number.guess.ToString();
			//Debug.Log(this.guessCoin);
		} else {
			
			SceneManager.LoadScene("Win");
		}
	}
}
