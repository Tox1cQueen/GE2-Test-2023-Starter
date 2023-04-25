using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject AmongG;
    public GameObject AmongR;
    public GameObject AmongB;
    public GameObject AmongP;
    public GameObject AmongY;
    public int Us;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Us == 1)
        {
            AmongG.SetActive(true);
        }
        if (Us == 2)
        {
            AmongR.SetActive(true);
        }
        if (Us == 3)
        {
            AmongB.SetActive(true);
        }
        if (Us == 4)
        {
            AmongP.SetActive(true);
        }
        if (Us == 5)
        {
            AmongY.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (Us == 1)
        {
            AmongG.SetActive(false);
        }
        if (Us == 2)
        {
            AmongG.SetActive(false);
        }
        if (Us == 3)
        {
            AmongG.SetActive(false);
        }
        if (Us == 4)
        {
            AmongG.SetActive(false);
        }
        if (Us == 5)
        {
            AmongG.SetActive(false);
        }
        Us = Random.RandomRange(1,5);
    }
}
