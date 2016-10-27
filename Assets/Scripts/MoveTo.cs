using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

    // Use this for initialization
    void Start () {
        GameObject[] shootingPoints;
        int randPoint;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        Transform spawn = GameObject.FindGameObjectWithTag("Spawn").transform;

        gameObject.transform.position = spawn.position;

        shootingPoints = GameObject.FindGameObjectsWithTag("ShootingPoint");
        randPoint = Random.Range(0, shootingPoints.Length);
        agent.destination = shootingPoints[randPoint].gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
