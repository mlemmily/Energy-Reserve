using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextBoss : MonoBehaviour
{

    public GameObject Text;
    public GameObject Text2;

    public GameObject Text3;

    public GameObject Smoke;

    public GameObject CameraOLD;

    public GameObject CameraNEW;

    public GameObject CanvasOBJ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextStart());
    }

    IEnumerator TextStart()
    {
        yield return new WaitForSeconds(1.5f);
        Text.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        Text.SetActive(false);

        Text2.SetActive(true);
        yield return new WaitForSeconds(3f);
        Text2.SetActive(false);

        yield return new WaitForSeconds(4f);
        Smoke.SetActive(true);

        yield return new WaitForSeconds(2f);
        Smoke.SetActive(false);
        Text3.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        Text3.SetActive(false);
        CameraOLD.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        CameraNEW.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        CanvasOBJ.SetActive(true);
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Menu");
    }
}
