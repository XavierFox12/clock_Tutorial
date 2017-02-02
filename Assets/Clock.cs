using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Quaternion euler = Quaternion.Euler(new Vector3(0f, 0f, Time.time * 360f));
		transform.localRotation = euler;
	}
}
