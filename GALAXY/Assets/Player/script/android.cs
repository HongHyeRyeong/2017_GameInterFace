using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;

}

public class android : MonoBehaviour {

    private Touch tempTouchs;
    private Vector3 touchedPos;
    private bool touchOn;


    public float speed;
    public float dest;
    public float tilt;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;


    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
           // GetComponent<AudioSource>().Stop();
        }
    }

    void FixedUpdate()
	{
		touchedPos = Camera.main.ScreenToWorldPoint (tempTouchs.position);


		if (touchedPos.x > 0 || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-speed, 0, 0);
		} else if (touchedPos.x < 0 || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed, 0, 0);
		}

		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		GetComponent<Rigidbody> ().velocity = movement * speed;


		GetComponent<Rigidbody> ().position = new Vector3 (
			Mathf.Clamp (GetComponent<Rigidbody> ().position.x, boundary.xMin, boundary.xMax),
			0.0f,
			0.0f
		);

		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody> ().velocity.x * -tilt);
	}
}