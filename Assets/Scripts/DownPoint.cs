using UnityEngine;
using System.Collections;

public class DownPoint : MonoBehaviour {

    public Transform head;
    public float downAmount = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 headPos = head.position;
        headPos.y -= downAmount;
        transform.position = headPos;
	}
}
