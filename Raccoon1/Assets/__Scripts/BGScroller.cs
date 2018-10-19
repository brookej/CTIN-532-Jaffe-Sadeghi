using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {
    private Transform cameraTransform;
    private Transform[] layers;
    private float viewZone = 32.75f;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraX;

    public float backgroundSize;
    public float parallaxSpeed;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraX = cameraTransform.position.x;
        layers = new Transform[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {
            layers[i] = transform.GetChild(i);
        }
        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }

    private void ScrollLeft()
    {
        layers[rightIndex].position = new Vector3((layers[leftIndex].position.x - backgroundSize),
            layers[rightIndex].position.y,
            layers[rightIndex].position.z);
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)
        {
            rightIndex = layers.Length - 1;
        }
    }

    private void ScrollRight()
    {
        layers[leftIndex].position = new Vector3((layers[rightIndex].position.x + backgroundSize),
            layers[leftIndex].position.y,
            layers[leftIndex].position.z);
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
        {
            leftIndex = 0;
        }
    }

    private void Update()
    {
        //float deltaX = cameraTransform.position.x - lastCameraX;
        //transform.position += Vector3.right * (deltaX);
        //transform.position = Vector3.Lerp(transform.position, transform.position + (Vector3.right * (deltaX * parallaxSpeed)),Time.deltaTime);
        //lastCameraX = cameraTransform.position.x;
        if(cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewZone))
        {
            ScrollLeft();
        }
        else if (cameraTransform.position.x > (layers[leftIndex].transform.position.x - viewZone))
        {
            ScrollRight();
        }
    }

    private void LateUpdate()
    {
        float deltaX = lastCameraX - cameraTransform.position.x;
        transform.position += Vector3.right * (deltaX * parallaxSpeed);
        lastCameraX = cameraTransform.position.x;
    }
}
