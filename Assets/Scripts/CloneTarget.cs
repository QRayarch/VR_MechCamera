using UnityEngine;
using System.Collections;

public class CloneTarget : MonoBehaviour {

    public Transform head;
    public Transform objectToEffect;
    public float scaleMultiplyer = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = transform.position - head.position;
        offset.y = 0;
        objectToEffect.localPosition = (head.InverseTransformPoint(transform.position)) * scaleMultiplyer;
        objectToEffect.localRotation = transform.localRotation;
	}
}
