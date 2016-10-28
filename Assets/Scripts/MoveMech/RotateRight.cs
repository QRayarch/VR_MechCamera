using UnityEngine;
using System.Collections;

public class RotateRight : RotateBase {

    public float rotateAmount = 1;

    public override void Activate(GameObject mech)
    {
        mech.transform.rotation *= Quaternion.Euler(0, rotateAmount * Time.deltaTime, 0);
    }

}
