using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {
	private bool tap, swipeUp, swipeDown, swipeLeft, swipeRight, isDragging = false;
	private Vector2 startTouch, swipeDelta;

	private void Update()
	{
		tap = swipeUp = swipeDown = swipeRight = swipeLeft = false;

		#region Standalone Input
		if(Input.GetMouseButtonDown(0))
		{
			tap = true;
			isDragging = true;
			startTouch = Input.mousePosition;
		}
		else if(Input.GetMouseButtonUp(0))
		{
			Reset ();
			isDragging = false;
		}
		#endregion

		#region Mobile Input
		if(Input.touches.Length > 0)
		{
			if(Input.touches[0].phase == TouchPhase.Began)
			{
				tap = true;
				isDragging = true;
				startTouch = Input.touches[0].position;
			}
			else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
			{
				Reset ();
				isDragging = false;
			}
		}
		#endregion

		//Perhitungan jarak Swipe
		swipeDelta = Vector2.zero;
		if (isDragging) 
		{
			if (Input.touches.Length > 0) {
				swipeDelta = Input.touches [0].position - startTouch;
				Debug.Log (SwipeDelta);
			} 
			else if (Input.GetMouseButton (0)) {
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
				Debug.Log (SwipeDelta);
			}
		}

		//Pengecekan Jarak Swipe
		if (swipeDelta.magnitude > 125) 
		{
			//Cek Arah Swipe
			float x = swipeDelta.x;
			float y = swipeDelta.y;

			if (Mathf.Abs (x) > Mathf.Abs (y)) {
				//Kiri atau Kanan
				if (x > 0)
					swipeRight = true;
				else
					swipeLeft = true;
			} else {
				//Atas atau Bawah
				if (y > 0)
					swipeUp = true;
				else
					swipeDown = true;
			}
		}
	}

	private void Reset()
	{
		startTouch = swipeDelta = Vector2.zero;
		isDragging = false;
	}

	public Vector2 SwipeDelta{ get { return swipeDelta; } }
	public bool SwipeUp{ get { return swipeUp; } }
	public bool SwipeDown{ get { return swipeDown; } }
	public bool SwipeRight{ get { return swipeRight; } }
	public bool SwipeLeft{ get { return swipeLeft; } }
}
