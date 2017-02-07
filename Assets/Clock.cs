using UnityEngine;
using System.Collections;
using System;

public class Clock : MonoBehaviour {
	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;

	void Update()
	{
		DateTime time = DateTime.Now;

		//Seconds
		int seconds = time.Second;

		float seconds_normalized = seconds / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;

		Vector3 secondsRotation = new Vector3 (0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler (secondsRotation);
		secondHand.transform.rotation = secondsRotationQuat;

		//Minutes
		int minutes = time.Minute;

		float minutes_normalized = minutes / 60f;
		float minutes_degrees = minutes_normalized * 360f;
		float clockwise_minutes = 360f - minutes_degrees;

		Vector3 minutesRotation = new Vector3 (0f, 0f, clockwise_minutes);
		Quaternion minutesRotationQuat = Quaternion.Euler (minutesRotation);
		minuteHand.transform.rotation = minutesRotationQuat;

		//Hours
		int hour = time.Hour;

		float hour_normalized = hour / 12f;
		float hour_degrees = hour_normalized * 360f;
		float clockwise_hour = 360f - hour_degrees;

		Vector3 hourRotation = new Vector3 (0f, 0f, clockwise_hour);
		Quaternion hourRotationQuat = Quaternion.Euler (hourRotation);
		hourHand.transform.rotation = hourRotationQuat;
	}
}
