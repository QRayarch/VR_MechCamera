using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int maxEnemy;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
	    for(int i = 0; i < maxEnemy; i++)
        {
            Instantiate(enemy);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
