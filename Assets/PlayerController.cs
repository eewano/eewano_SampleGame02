using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	[SerializeField] private float FBSpeed;
	[SerializeField] private float RotSpeed;
	[SerializeField] private GameObject shot;
	[SerializeField] private Transform shotSpawn;

	public Boundary boundary;

	void Start () {
	
	}

	void Update()
	{
		float translation = Input.GetAxis ("Vertical") * FBSpeed;
		float rotation = Input.GetAxis ("Horizontal") * RotSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);

		transform.position = new Vector3(Mathf.Clamp (transform.position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (transform.position.z, boundary.zMin, boundary.zMax));
		
		if (Input.GetMouseButtonDown(0)) 
		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}