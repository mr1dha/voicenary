using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestionController : MonoBehaviour{

	private string[] questions = {
		"apple", "book","school","pencil"
	};
	private int currentQuestions;

	public QuestionController(){
		currentQuestions = 0;
	}

	public int CurrentQuestion{
		get{ return currentQuestions;}
		set{ currentQuestions = value;}
	}

	public string Question{
		get{
			return questions[currentQuestions];
		}
	}
}
