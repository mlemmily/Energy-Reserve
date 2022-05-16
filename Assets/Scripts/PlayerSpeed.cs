using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed : MonoBehaviour
{
    [SerializeField] float newmoveSpeed;
    float originalmoveSpeed;
    private void OnTriggerEnter(Collider other)
    {
        originalmoveSpeed = other.gameObject.GetComponent<PlayerController>().moveSpeed;
        other.gameObject.GetComponent<PlayerController>().moveSpeed = newmoveSpeed;
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<PlayerController>().moveSpeed = originalmoveSpeed;
    }
}
