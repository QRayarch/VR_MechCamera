using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    public GameObject mech;

    void moveMechFwd() {
        Vector3 fwd = mech.transform.forward;

        mech.transform.position = mech.transform.position + (fwd*10 * Time.deltaTime);
    }
	// Update is called once per frame
	void Update () {
        //if(viveStuffHere){
        // moveMechFwd();    
        //}
	}
}
