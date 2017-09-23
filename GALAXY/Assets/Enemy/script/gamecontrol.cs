using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour {

	public GameObject enemy;
	public Vector3 spawnValues;
	public int enemyCnt;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start () {
		StartCoroutine (spawnWaves ());
	}

	IEnumerator spawnWaves (){
		yield return new WaitForSeconds (startWait);

		while (true) {
			for (int i = 0; i < enemyCnt; ++i) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

}