using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCheck : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject SpawnPoint;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            GameObject respawn = Instantiate(playerPrefab);

            respawn.transform.position = new Vector3(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y, SpawnPoint.transform.position.z);
        }
    }
}
