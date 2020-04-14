using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text recognizedText;

	private QuestionController question;

	void Start () {
		question = GetComponent<QuestionController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(recognizedText.text.Contains("book") || recognizedText.text.Contains("apple")){
			Debug.Log("GAME MANAGER FOUND!");
			Debug.Log(Time.time * 1000);
			question.CurrentQuestion++;
		}
	}
}
