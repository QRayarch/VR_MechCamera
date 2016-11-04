using UnityEngine;
using System.Collections;

public class GunStuff : MonoBehaviour {

    public GameObject firePoint;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
	}
	
    void FireBullet() {
        
        Rigidbody rb= ((GameObject)Instantiate(bullet,firePoint.transform.position,Quaternion.identity)).GetComponent<Rigidbody>();
        rb.AddForce(firePoint.transform.forward * 10000);
    }

	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0)) {
            FireBullet();
        }
	}
}
