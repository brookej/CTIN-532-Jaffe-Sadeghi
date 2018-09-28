using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour {
    public GameObject trashPrefab;
    public float rangeX;
    public float rangeY;

    private void Start()
    {
        SpawnTrash();
    }

    public void SpawnTrash()
    {
        //spawn trash
        GameObject trashToSpawn = trashPrefab;

        //set location of trash
        GameObject newTrash = Instantiate(trashToSpawn, new Vector3(Random.Range(rangeX, -rangeX), Random.Range(rangeY, -rangeY), this.GetComponent<Transform>().position.z), Quaternion.identity);
    }
}
