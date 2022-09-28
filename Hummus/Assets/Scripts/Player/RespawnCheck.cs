using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCheck : MonoBehaviour
{
    public GameObject playerPrefab;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            GameObject respawn = Instantiate(playerPrefab);
            respawn.transform.position = new Vector3(0.0f, respawn.transform.position.y, 0.0f);
        }
    }
}
