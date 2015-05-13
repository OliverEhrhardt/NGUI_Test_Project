using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InitScrollView : MonoBehaviour {


	//////////////PUBLIC VARIABLES//////////////

	//parent of scroll view sprites
	public GameObject container; 

	//instance of scroll view sprite
	public GameObject scrollViewSprite; 

	//scroll view refrence
	public UIScrollView thisScrollView;

	//how many object we will be appending
	public int itemLimit;

	//scroll bar changed red rgb value
	public GameObject redScrollBar;
	
	//scroll bar changed blue rgb value
	public GameObject blueScrollBar;

	//scroll bar changed green rgb value
	public GameObject greenScrollBar;

	//////////////PRIVATE VARIABLES//////////////

	//scroll bar refrence;
	private UISlider slider;

	//color of sprites
	private Color currentColor;

	//UISprite to set depth
	private UISprite sprite;

	//UIDragScrollView to give the sprite UIDrageScrollView
	private UIDragScrollView dragScrollView;

	//list of sprite elements
	private List<GameObject> spriteList = new List<GameObject>();
	
	// Use this for initialization
	void Start () 
	{
		currentColor = new Color ();
		for (int i = 0; i < itemLimit; i++) 
		{
			//create copy
			GameObject scrollViewSpriteCopy = Instantiate(scrollViewSprite, scrollViewSprite.transform.position, Quaternion.identity) as GameObject;
			//setting parent as container
			scrollViewSpriteCopy.transform.parent = container.transform;
			//changing scale of copy to match scale of scene
			scrollViewSpriteCopy.transform.localScale = new Vector3(1,1,1);
			//editing the depth of the sprite
			sprite = scrollViewSpriteCopy.GetComponent<UISprite>();
			sprite.depth = 2;
			//giving UIDragScrollView
			dragScrollView = scrollViewSpriteCopy.GetComponent<UIDragScrollView>();
			dragScrollView.enabled = true;
			dragScrollView.scrollView = thisScrollView;
			//appending to list
			spriteList.Add(scrollViewSpriteCopy);

		}
	}
	//updates every second
	void Update()
	{
		//set alpha
		currentColor.a = 1;
		//set red 
		slider = redScrollBar.GetComponent<UISlider> ();
		currentColor.r = slider.value;
		//set blue
		slider = blueScrollBar.GetComponent<UISlider> ();
		currentColor.b = slider.value;
		//set green
		slider = greenScrollBar.GetComponent<UISlider> ();
		currentColor.g = slider.value;
		//set color to sprites in scroll view
		for (int i = 0; i < itemLimit; i++) 
		{
			sprite = spriteList[i].GetComponent<UISprite>();
			sprite.color = currentColor;
		}
	}
}
