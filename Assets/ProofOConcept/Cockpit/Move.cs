using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vel = Vector3.zero ;
        if(Input.GetKey(KeyCode.W)){
            vel += Vector3.forward * 10;
        } else if (Input.GetKey(KeyCode.S))
        {
            vel += Vector3.forward * -10;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            vel += Vector3.left * 10;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            vel += Vector3.right * 10;
        }

        transform.position = transform.position + (vel * Time.deltaTime);
    }
}
