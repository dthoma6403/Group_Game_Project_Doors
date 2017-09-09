using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour 
{
	public bool startRotationFlag;
	public Transform target;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		
	}

	void Update()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		if(startRotationFlag){
			this.transform.Rotate ( new Vector3(45,0,0) * Time.deltaTime );
							}
	}

	void OnMouseUp()
	{
		startRotationFlag = true;
	}

}

