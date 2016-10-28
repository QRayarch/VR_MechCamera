using UnityEngine;
using System.Collections;

public class MoveForward : RotateBase {

    public override void Activate(GameObject mech)
    {
        Vector3 fwd = mech.transform.forward;

        mech.transform.position = mech.transform.position + (fwd*10 * Time.deltaTime);
    }

}
