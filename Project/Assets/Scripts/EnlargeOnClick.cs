using UnityEngine;
using System.Collections;

public class EnlargeOnClick : MonoBehaviour {

	//////////////PUBLIC VARIABLES//////////////

	//sprite to enlarge
	public GameObject enlargeSprite;

	//////////////PRIVATE VARIABLES//////////////

	//control tween component
	private TweenScale scaleTween;

	//boolean to check state
	private bool isScaled = false;


	//use this for initialization
	void Start()
	{
		//gets scale tween component on start
		scaleTween = enlargeSprite.GetComponent<TweenScale> ();
	}

	void OnClick()
	{
		if (!isScaled) 
		{
			scaleTween.PlayForward ();
			isScaled = true;
		} else 
		{
			scaleTween.PlayReverse();
			isScaled = false;
		}
	}
}
