using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    void Start () {
	}
	[SerializeField] Transform particleObj;
	RaycastHit hit;
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		bool is_hit = Physics.Raycast (ray, out hit, 1000);
		if (is_hit) {
			particleObj.transform.position = hit.point;
			particleObj.rotation = 
				Quaternion.FromToRotation (transform.forward, hit.normal);
		}
	}
}
