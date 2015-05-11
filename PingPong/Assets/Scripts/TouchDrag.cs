using UnityEngine;
using System.Collections;

public class TouchDrag : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float xPositionOfMouseOnScreen;
	public float yPositionOfMouseOnScreen ;
	public float xPositionOfCamera;
	public float yPositionOfCamera;
	
	Vector2 OffsetLocation ;

	void OnMouseDown()
	{

		Vector2 mousePositionTemp;
		
		mousePositionTemp = Input.mousePosition;
		xPositionOfMouseOnScreen = mousePositionTemp.x;
		yPositionOfMouseOnScreen = mousePositionTemp.y;
		
		Vector3 positionTemp;
		
		
		
		positionTemp = Camera.main.ScreenToWorldPoint (new Vector3 (mousePositionTemp.x, mousePositionTemp.y, 0));
		
		
		xPositionOfCamera = positionTemp.x;
		yPositionOfCamera = positionTemp.y;
		
		OffsetLocation = transform.position - positionTemp;

	}
	void OnMouseDrag () 
	{

		Vector2 mousePositionTemp;
		
		mousePositionTemp = Input.mousePosition;
		xPositionOfMouseOnScreen = mousePositionTemp.x;
		yPositionOfMouseOnScreen = mousePositionTemp.y;
		
		Vector3 position = Camera.main.ScreenToWorldPoint (new Vector3 (mousePositionTemp.x,mousePositionTemp.y,0));    
		
		xPositionOfCamera = position.x;
		yPositionOfCamera = position.y;
			
			
		transform.position = new Vector2( Mathf.Clamp( xPositionOfCamera + OffsetLocation.x , -11.5f, 11.5f ), transform.position.y );
		
	}
	
	void OnMouseUp () 
	{
		
	}

}
