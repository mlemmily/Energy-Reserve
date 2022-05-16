using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn4 : MonoBehaviour
{
    public GameObject RespawnPlayer2;
    public Transform respawnZone2;
    public GameObject empty;

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
        StartCoroutine(RespawnNEW1());
    }

    IEnumerator RespawnNEW1()
    {
        Instantiate(empty);
        Instantiate(RespawnPlayer2);
        RespawnPlayer2.transform.position = respawnZone2.position;
        yield return new WaitForSeconds(0.5f);
        Destroy(GameObject.Find("CharModel"));
        Destroy(GameObject.Find("CharModel(Clone)"));
        
        yield return new WaitForSeconds(4f);
        Instantiate(RespawnPlayer2);
        RespawnPlayer2.transform.position = respawnZone2.position;
        yield return new WaitForSeconds(0.2f);
        Destroy(GameObject.Find("deathcanvas"));
        Destroy(GameObject.Find("deathcanvas(Clone)"));
        
    }
}

