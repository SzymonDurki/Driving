using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

public GameObject LapCompleteTrig;
public GameObject HalfLapTrig;

private void OnTriggerEnter(Collider other) {
	Debug.Log("HalfPointTrigger2");
}

void OnTriggerEnter () {
	LapCompleteTrig.SetActive (true);
	HalfLapTrig.SetActive (false);

	Debug.Log("HalfPointTrigger");
}

}
