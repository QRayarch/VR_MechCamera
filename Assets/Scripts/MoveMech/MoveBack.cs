using UnityEngine;
using System.Collections;

public class MoveBack : RotateBase {

    public override void Activate(GameObject mech)
    {
        Vector3 back = -mech.transform.forward;

        mech.transform.position = mech.transform.position + (back*10 * Time.deltaTime);
    }
}
