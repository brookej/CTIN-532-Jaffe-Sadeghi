using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTrashSpawn : MonoBehaviour {

    //public TrashBehavior behavior;
    public GameObject trashPrefab;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

	// Use this for initialization
	void Start () {
        Instantiate(trashPrefab, new Vector3(transform.position.x + Random.Range(xMin, xMax),
                                            transform.position.y + Random.Range(yMin, yMax),
                                             transform.position.z), Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
