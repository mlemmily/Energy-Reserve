using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn2 : MonoBehaviour
{
    public GameObject RespawnPlayer;
    public Transform respawnZone;
    public GameObject CanvasDeath;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(CanvasDeath);
        StartCoroutine(RespawnNEW());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator RespawnNEW()
    {
        Instantiate(RespawnPlayer);
        RespawnPlayer.transform.position = respawnZone.position;
        yield return new WaitForSeconds(0.5f);
        Destroy(GameObject.Find("CharModel"));
        Destroy(GameObject.Find("CharModel(Clone)"));

        yield return new WaitForSeconds(4f);
        Instantiate(RespawnPlayer);
        RespawnPlayer.transform.position = respawnZone.position;
        yield return new WaitForSeconds(0.2f);
        Destroy(GameObject.Find("deathcanvas"));
        Destroy(GameObject.Find("deathcanvas(Clone)"));
    }
}
