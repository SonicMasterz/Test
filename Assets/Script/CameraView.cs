using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class CameraView : MonoBehaviour {
	public Camera cam;
	public GameObject goObject;
	public float senX = 2,senY = 2,moveSpeed = 2;

	void Start () {
		//AudioSource.PlayClipAtPoint (clip, transform.position,volume:0.3f);
		//cam.transform.LookAt (transform.position);
	}

	void Update () {
		cam.transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel")*6);
		if (Input.GetKey (KeyCode.Mouse0)) {
			transform.Rotate(-Input.GetAxis("Mouse Y")*senX,Input.GetAxis("Mouse X")*senY,0);
		}
		cam.transform.LookAt(transform.position);

	}
}
