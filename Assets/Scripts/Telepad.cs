using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepad : MonoBehaviour
{

    public GameObject RespawnPlayer1;
    public Transform respawnZone1;


    void OnTriggerEnter()
    {
        Destroy(GameObject.Find("CharModelFinalLEVEL"));
        Destroy(GameObject.Find("CharModelFinalLEVEL(Clone)"));
        StartCoroutine(Tele());
    }

    IEnumerator Tele()
    {
        Instantiate(RespawnPlayer1);
        RespawnPlayer1.transform.position = respawnZone1.position;
        yield return new WaitForSeconds(0.1f);
        Destroy(GameObject.Find("CharModelFinalLEVEL"));
        Destroy(GameObject.Find("CharModelFinalLEVEL(Clone)"));

        yield return new WaitForSeconds(0.25f);
        Instantiate(RespawnPlayer1);
        RespawnPlayer1.transform.position = respawnZone1.position;
        Destroy(GameObject.Find("deathcanvas"));
        Destroy(GameObject.Find("deathcanvas(Clone)"));
    }

}
