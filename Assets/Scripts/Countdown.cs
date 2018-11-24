using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour {

    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject CarControls;
    public GameObject CarControl;
    public AudioSource LevelMusic;

	void Start () {
        StartCoroutine (CountStart ());
	}
	

    IEnumerator CountStart () {

       CarControl.GetComponent<CarController>().enabled = false;

        yield return new WaitForSeconds (0.5f);
        CountDown.GetComponent<Text> ().text = "3";
        GetReady.Play ();
        CountDown.SetActive (true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<Text> ().text = "2";
        GetReady.Play ();
		CountDown.SetActive (true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<Text> ().text = "1";
		GetReady.Play ();
        CountDown.SetActive (true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        GoAudio.Play ();
        LevelMusic.Play (); 
        LapTimer.SetActive (true);
        CarControls.SetActive (true);
        CarControl.GetComponent<CarController>().enabled = true;

	}


}
