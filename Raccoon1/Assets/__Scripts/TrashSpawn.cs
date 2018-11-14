using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour {
    public GameObject trashPrefab;
    public float maxRangeX;
    public float minRangeX;
    public float rangeY;
    public TrashBehavior behavior;

    private void Start()
    {
        SpawnTrash();
    }


    public void SpawnTrash()
    {
        //spawn trash
        GameObject trashToSpawn = trashPrefab;

        //set location of trash
        GameObject newTrash = Instantiate(trashToSpawn, new Vector3(Random.Range(this.transform.position.x+ minRangeX, (this.transform.position.x + maxRangeX)), Random.Range(rangeY, -rangeY)), Quaternion.identity);
        newTrash.GetComponent<TrashBehavior>().spawn = this;
    }
}
