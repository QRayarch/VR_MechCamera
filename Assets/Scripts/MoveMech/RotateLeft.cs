using UnityEngine;
using System.Collections;

public class RotateLeft : MonoBehaviour {

    public GameObject mech;

    void rotateMechLeft() {
        mech.transform.RotateAround(transform.position,Vector3.up,-50 * Time.deltaTime);
    }
	// Update is called once per frame
	void Update () {
	    //if(viveStuffHere){
        // rotateMechLeft();    
        //}
	}
}
