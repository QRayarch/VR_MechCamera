using UnityEngine;
using System.Collections;

public abstract class RotateBase : MonoBehaviour
{

    public Material touchedMat;

    private GameObject mech;
    private MeshRenderer meshRen;
    private Material oldMat;

    // Use this for initialization
    void Start()
    {
        mech = GameObject.FindGameObjectWithTag("Player");
        meshRen = GetComponent<MeshRenderer>();
        oldMat = meshRen.material;
    }

    public abstract void Activate(GameObject mech);

    void OnTriggerEnter(Collider o)
    {
        meshRen.material = touchedMat;
    }

    void OnTriggerStay(Collider other)
    {
        Activate(mech);
    }

    void OnTriggerExit(Collider o)
    {
        meshRen.material = oldMat;
    }
}
