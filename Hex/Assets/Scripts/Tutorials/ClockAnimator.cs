using System;
using UnityEngine;

namespace Tutorials
{
	public class ClockAnimator : MonoBehaviour
	{
		public Transform Hours, Minutes, Seconds;
		public bool Analog;

		private const float HoursToDegrees = 360f / 12f;
		private const float MinutesToDegrees = 360f / 60f;
		private const float SecondsToDegrees = 360f / 60f;

		private void Update()
		{
			if (Analog)
			{
				var timeSpan = DateTime.Now.TimeOfDay;
				
				Hours.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalHours * -HoursToDegrees);
				Minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalMinutes * -MinutesToDegrees);
				Seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalSeconds * -SecondsToDegrees);
			}
			else
			{
				var time = DateTime.Now;
			
				Hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -HoursToDegrees);
				Minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -MinutesToDegrees);
				Seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -SecondsToDegrees);
			}
		}
	}
}
