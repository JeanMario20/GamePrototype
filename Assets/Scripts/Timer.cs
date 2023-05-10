using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text timerMinutes;
	public Text falseMinute;
	public Text timerSeconds;
	public Text falseSeconds;
	public Text timerSeconds100;

	



    private float startTime;
	private float stopTime;
	private float timerTime;

	public int countMin = 0;
	public bool isCountMin = true;

	void Start() {
		TimerResert();
		
	}

	public void stopCounMinute(){
		
	}

	public void TimerStart(){
		startTime = Time.time;
	}


	public void TimerResert(){
		//timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
		 startTime = Time.time;
         stopTime = 0f;
	}

	// Update is called once per frame
	void Update () {

		timerTime = stopTime + (Time.time - startTime);
		int minutesInt = (int)timerTime / 60;
		int secondsInt = (int)timerTime % 60;
		int seconds100int = (int)(Mathf.Floor((timerTime -(secondsInt + minutesInt * 60)) * 100));
		
			if(secondsInt > 59){
				Destroy(falseMinute);
			}
			if (secondsInt > 9){
				Destroy(falseSeconds);
				//GetComponent<RecTransform>().anchoredPosition = new Vector2(-299,280);
				timerSeconds.GetComponent<RectTransform>().anchoredPosition  = new Vector2(-299,280);
				
				
			}
	
		

		timerMinutes.text = minutesInt.ToString();
		timerSeconds.text = secondsInt.ToString();
		timerSeconds100.text = seconds100int.ToString();
		
		
	}

	
}
