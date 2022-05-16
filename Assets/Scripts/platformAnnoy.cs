using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformAnnoy : MonoBehaviour
{
    public GameObject evilPlat;
    public GameObject goodPlat;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            goodPlat.SetActive(false);
            evilPlat.SetActive(true);
        }
    }
}
