using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberWizard : MonoBehaviour {

	[SerializeField]
	int max;

	[SerializeField]
	int min;

	[SerializeField]
	TextMeshProUGUI guessText; 

	private int _nextGuess;

	// Use this for initialization
	void Start () {
		UpdateGuess();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnPressHigher()
	{
		min = _nextGuess + 1;
		UpdateGuess();
	}

	public void OnPressLower()
	{
		max = _nextGuess - 1;
		UpdateGuess();
	}

	private void UpdateGuess()
	{
		if (min < max)
		{
			_nextGuess = Random.Range(min, max + 1);
		}
		guessText.SetText(_nextGuess.ToString());
	}
}
