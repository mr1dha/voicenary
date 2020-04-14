using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestionController : MonoBehaviour{

	private string[] questions = {
		"apple", "book","school","pencil","publication", 
	};
	private int currentQuestion;

	public QuestionController(){
		currentQuestion = 0;
	}

	public int CurrentQuestion{
		get{ return currentQuestion;}
		set{ currentQuestion = value;}
	}

	public string Question{
		get{
			if(currentQuestion < questions.Length){
				return questions[currentQuestion];
			}else{
				return null;
			}
		}
	}
}
