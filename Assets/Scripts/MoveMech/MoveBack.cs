using UnityEngine;
using System.Collections;

public class MoveBack : MonoBehaviour {

    public GameObject mech;

    void moveMechBack() {
        Vector3 back = -mech.transform.forward;

        mech.transform.position = mech.transform.position + (back*10 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
	    //if(viveStuffHere){
        // moveMechBack();    
        //}
	}
}
