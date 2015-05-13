using UnityEngine;
using System.Collections;

/*
Summary:
Event for random button, changes value on slider to a random float value between 0 and 1.
 */

public class RandomButton : MonoBehaviour {

	//////////////PUBLIC VARIABLES//////////////
	
	//scroll bars controll rgb values depending on which scroll bar
	public GameObject redScrollBar;
	public GameObject blueScrollBar;
	public GameObject greenScrollBar;

	//////////////PRIVATE VARIABLES//////////////

	//get slider component
	private UISlider slider;

	void OnClick(){
		//randomize red
		slider = redScrollBar.GetComponent<UISlider> ();
		slider.value = (Random.Range(0,11) * 0.1f);
		//randomize green
		slider = greenScrollBar.GetComponent<UISlider> ();
		slider.value = (Random.Range(0,11) * 0.1f);
		//randomize blue
		slider = blueScrollBar.GetComponent<UISlider> ();
		slider.value = (Random.Range(0,11) * 0.1f);
	}
}