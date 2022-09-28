using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    public int Health = 100;
    public GameObject resource;
    public GameObject player;

    public float distance;

    void OnMouseDown() //runs when a mouse click has been done
    {
        distance = (resource.transform.position - player.transform.position).magnitude;
        Health -= 50;
        if (Health <= 0 && distance <= 3)
        {
            Destroy(resource);
        }
    }
}
