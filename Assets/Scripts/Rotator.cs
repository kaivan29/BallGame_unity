using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15,30,45)*Time.deltaTime);
		//public void Rotate(Vector3 eulerAngles, Space relativeTo = Space.Self); 
		//15, 45 and 30 are euler angles
		//we are going to keep space default here.
	}

	//A prefab is an asset that contains a template
}
