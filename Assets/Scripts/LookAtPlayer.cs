using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	public Transform lookAt;

	void Start () {
		lookAt = PlayerController.Instance.transform;
	}
	
	void Update () {
		transform.rotation = Quaternion.LookRotation(lookAt.position - transform.position, Vector3.up);
	}
}
