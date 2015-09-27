using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;
	
	void Start()
	{
		offset = transform.position - player.transform.position;
		//the camera needs to move along with the object. Inertia!!
		//We have to stay true to the frame. Hence, the difference
		//our transform.position - camera position
	}

	void LateUpdate()
	{
		transform.position = offset + player.transform.position;
		//the camera is moved to the new position now.
		//So we need to update the position of the camera
		//For follow camera it is better to use LateUpdate rather than Update.
	}
}
