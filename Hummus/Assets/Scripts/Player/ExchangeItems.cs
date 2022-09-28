using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExchangeItems : MonoBehaviour
{
    public GameObject dialogue;

    //items can add more when know what ingredients
    public GameObject chickpea;
    public GameObject tahini;
    public GameObject garlic;
    public GameObject lemon;
    public GameObject oil;
    public GameObject salt;
    public GameObject juice;
    public GameObject cumin;

    // Update is called once per frame
    void Update()
    {
        if(dialogue.activeInHierarchy == true)
        {
            //code for exchanging items
            if (chickpea.activeSelf == true && tahini.activeSelf == true && garlic.activeSelf == true && lemon.activeSelf == true && oil.activeSelf == true && salt.activeSelf == true && juice.activeSelf == true && cumin.activeSelf == true && Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }
}
