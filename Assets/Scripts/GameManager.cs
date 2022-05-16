using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentGold;
    public int BadCoinValue;
    public Text goldText;
    public GameObject GoodTP;
    public GameObject BadTP;

    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;

    public GameObject GhostPlat1;
    public GameObject GhostPlat2;
    public GameObject GhostPlat3;
    public GameObject GhostPlat4;

    public GameObject BadCoin1;
    public GameObject BadCoin2;
    public GameObject BadCoin3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentGold > 4)
        {
            GhostPlat1.SetActive(false);
            platform1.SetActive(true);
        }

        if (currentGold > 9)
        {
            GhostPlat2.SetActive(false);
            platform2.SetActive(true);
        }

        if (currentGold > 19)
        {
            GhostPlat3.SetActive(false);
            platform3.SetActive(true);
            
        }

        if (currentGold > 29)
        {
            GhostPlat4.SetActive(false);
            platform4.SetActive(true);
        }

        if (BadCoinValue > 1)
        {
            GoodTP.SetActive(false);
            BadTP.SetActive(true);
        }
    }

    public void AddGold(int goldToAdd)
    {
        currentGold += goldToAdd;
        goldText.text = "ENERGY: " + currentGold;
    }

        public void AddBadCoin(int BadToAdd)
    {
        BadCoinValue += BadToAdd;
    }
}
