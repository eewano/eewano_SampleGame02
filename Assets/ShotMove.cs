using UnityEngine;
using System.Collections;

public class ShotMove : MonoBehaviour {

	[SerializeField] private float shotSpeed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;
	}
}
