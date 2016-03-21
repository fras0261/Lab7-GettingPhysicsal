using UnityEngine;
using System.Collections;

public class ObjectGun : MonoBehaviour {

    public GameObject objectToShoot;
    public Vector3 spawnOffset;
    public float impulseAmount;

	// Use this for initialization
	void Start () {
	    if (objectToShoot != null && objectToShoot.GetComponent<Rigidbody>())
        {
            Debug.Log("It's all good, mate");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Rigidbody rigidBody = objectToShoot.GetComponent<Rigidbody>();
            if (rigidBody != null)
            {
                GameObject newGO = GameObject.Instantiate(objectToShoot);

                Vector3 positionToSpawnAt = transform.position + (transform.forward) + spawnOffset;
                newGO.transform.position = positionToSpawnAt;

                rigidBody = newGO.GetComponent<Rigidbody>();
                rigidBody.AddForce(transform.forward * impulseAmount, ForceMode.Impulse);

            } 
        }
	}
}
