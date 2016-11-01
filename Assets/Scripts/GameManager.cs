using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int maxEnemy;
    public GameObject enemy;
    private GameObject player;
    private int hitCount;
    private GameObject[] monitors;

	// Use this for initialization
	void Start () {
	    for(int i = 0; i < maxEnemy; i++)
        {
            Instantiate(enemy);
        }

        player = GameObject.FindGameObjectWithTag("Player");
        monitors = GameObject.FindGameObjectsWithTag("Monitor");
        hitCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void PlayerHit()
    {
        // Disable camera 1 - 6
        switch (hitCount)
        {
            case  5: monitors[0].GetComponent<MeshRenderer>().enabled = false;
                     break;
            case 10: monitors[1].GetComponent<MeshRenderer>().enabled = false;
                     break;
            case 15: monitors[2].GetComponent<MeshRenderer>().enabled = false;
                     break;
            case 20: monitors[3].GetComponent<MeshRenderer>().enabled = false;
                     break;
            case 25: monitors[4].GetComponent<MeshRenderer>().enabled = false;
                     break;
            case 30: monitors[5].GetComponent<MeshRenderer>().enabled = false;
                     break;
            default: break;
        }
    }
}
