using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatObs : MonoBehaviour
{

    public GameObject Object1;
    public GameObject Object22;
    public GameObject Object333;
    public GameObject Object4444;

    public GameObject BadObject1;
    public GameObject BadObject22;
    public GameObject BadObject333;
    public GameObject BadObject4444;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Object1.SetActive(false);
            Object22.SetActive(false);
            Object333.SetActive(false);
            Object4444.SetActive(false);

            BadObject1.SetActive(true);
            BadObject22.SetActive(true);
            BadObject333.SetActive(true);
            BadObject4444.SetActive(true);
        }
    }

}
