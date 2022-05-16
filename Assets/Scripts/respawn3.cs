using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn3 : MonoBehaviour
{
    public GameObject RespawnPlayer1;
    public Transform respawnZone1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Destroy(GameObject.Find("CharModel"));
        Destroy(GameObject.Find("CharModel(Clone)"));
        Destroy(GameObject.Find("CharModelFinalLEVEL"));
        Destroy(GameObject.Find("CharModelFinalLEVEL(Clone)"));
        StartCoroutine(RespawnNEW1());
    }

    IEnumerator RespawnNEW1()
    {
        Instantiate(RespawnPlayer1);
        RespawnPlayer1.transform.position = respawnZone1.position;
        yield return new WaitForSeconds(0.1f);
        Destroy(GameObject.Find("CharModel"));
        Destroy(GameObject.Find("CharModel(Clone)"));
        Destroy(GameObject.Find("CharModelFinalLEVEL"));
        Destroy(GameObject.Find("CharModelFinalLEVEL(Clone)"));

        yield return new WaitForSeconds(0.25f);
        Instantiate(RespawnPlayer1);
        RespawnPlayer1.transform.position = respawnZone1.position;
        Destroy(GameObject.Find("deathcanvas"));
        Destroy(GameObject.Find("deathcanvas(Clone)"));
    }
}
