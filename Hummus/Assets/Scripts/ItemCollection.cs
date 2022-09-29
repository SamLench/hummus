using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollection : MonoBehaviour
{
    public GameObject ingredient;

    private void OnTriggerEnter(Collider other)
    {
        ingredient.SetActive(true);
        Destroy(this.gameObject);
    }
}
