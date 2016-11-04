using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public int maxEnemy;
    public GameObject enemy;
    private GameObject player;
    private int hitCount;
    private GameObject[] monitors;

    private List<int> moitersAlive = new List<int>();

    private float maxSpawn = 80000;

    // Use this for initialization
    void Start () {
	    for(int i = 0; i < maxEnemy; i++)
        {
            Instantiate(enemy);
        }

        player = GameObject.FindGameObjectWithTag("Player");
        monitors = GameObject.FindGameObjectsWithTag("Monitor");
        hitCount = 0;

        for(int i = 0; i < 7; i++)
        {
            moitersAlive.Add(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
        maxSpawn -= Time.deltaTime * 120;
        if (Random.Range(0, maxSpawn) < 230)
        {
            Instantiate(enemy);
        }
    }

    public void PlayerHit()
    {
        hitCount += 1;

        ushort amount = 3600;
        SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost)).TriggerHapticPulse(amount);
        SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost)).TriggerHapticPulse(amount);

        if (hitCount >= 15 && moitersAlive.Count > 0)
        {
            int index = Random.Range(0, moitersAlive.Count);
            int i = moitersAlive[index];
            moitersAlive.RemoveAt(index);
            monitors[i].GetComponent<MeshRenderer>().enabled = false;
            hitCount -= 5;
        }
    }
}
