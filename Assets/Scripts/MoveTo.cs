using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

    public float fireRate;
    private float lastShot;
    private NavMeshAgent agent;
    private GameObject player;
    private GameManager gameManager;

    // Use this for initialization
    void Start () {
        GameObject[] shootingPoints;
        int randPoint;
        agent = GetComponent<NavMeshAgent>();
        Transform spawn = GameObject.FindGameObjectWithTag("Spawn").transform;

        gameObject.transform.position = spawn.position;

        player = GameObject.FindGameObjectWithTag("Player");
        shootingPoints = GameObject.FindGameObjectsWithTag("ShootingPoint");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        randPoint = Random.Range(0, shootingPoints.Length);
        agent.destination = shootingPoints[randPoint].gameObject.transform.position;
        agent.speed = 10;
        agent.stoppingDistance = 5;
        agent.radius = 1;
    }
	
	// Update is called once per frame
	void Update () {
        // If enemy is at shooting point, check to shoot
        if (agent.remainingDistance <= 5)
        {
            // Calculate distance to player
            Vector3 distanceV3 = player.transform.position - this.transform.position;
            distanceV3.y = 0;
            float dist = distanceV3.magnitude;

            // If player is in view, then shoot
            if(dist <= 60 && Time.time > lastShot + fireRate)
            {
                // Reset fire rate time
                lastShot = Time.time;

                // Cast a ray, if it hits the player do damage
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 60))
                {
                    gameManager.PlayerHit();
                }
            }
        }
    }
}
