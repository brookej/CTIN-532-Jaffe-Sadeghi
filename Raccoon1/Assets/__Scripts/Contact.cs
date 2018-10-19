using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contact : MonoBehaviour {





	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Torso") 
		{
			Destroy (col.gameObject);
		}
	}
}
