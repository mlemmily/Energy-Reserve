using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadController : MonoBehaviour
{
    [SerializeField] float newJumpForce;
    float originalJumpForce;
    private void OnTriggerEnter(Collider other)
    {
        originalJumpForce = other.gameObject.GetComponent<PlayerController>().jumpForce;
        other.gameObject.GetComponent<PlayerController>().jumpForce = newJumpForce;
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<PlayerController>().jumpForce = originalJumpForce;
    }
}
