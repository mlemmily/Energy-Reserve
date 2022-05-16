using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickupBAD : MonoBehaviour
{
    public int value;
    public int BadCoinValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddGold(value);
            FindObjectOfType<GameManager>().AddBadCoin(BadCoinValue);
            StartCoroutine(RespawnNew11());
        }
    }



    IEnumerator RespawnNew11()
    {
        yield return new WaitForSeconds(6.25f);
        Destroy(gameObject);
    }

}

