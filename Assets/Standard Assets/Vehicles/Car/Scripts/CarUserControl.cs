using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
	[RequireComponent(typeof (CarController))]
	public class CarUserControl : MonoBehaviour
	{
		private CarController m_Car; // the car controller we want to use
		public int playerNo;
		
		private void Awake()
		{
			// get the car controller
			m_Car = GetComponent<CarController>();
		}
		
		
		private void FixedUpdate()
		{
			String hCTL = "";
			String vCTL = "";
			if (playerNo == 1) hCTL = "Horizontal1";
			if (playerNo == 1) vCTL = "Vertical1";
			
			if (playerNo == 2) hCTL = "Horizontal2";
			if (playerNo == 2) vCTL = "Vertical2";
			
			// pass the input to the car!
			float h = CrossPlatformInputManager.GetAxis(hCTL);
			float v = CrossPlatformInputManager.GetAxis(vCTL);
			#if !MOBILE_INPUT
			float handbrake = CrossPlatformInputManager.GetAxis("Jump");
			m_Car.Move(h, v, v, handbrake);
			#else
			m_Car.Move(h, v, v, 0f);
			#endif
		}
	}
}
