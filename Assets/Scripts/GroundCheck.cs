using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private bool isGrounded = true;
  

    private void OnTriggerStay2D(Collider2D collision)
    {
        isGrounded = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;

    }

    public bool CheckIfGrounded()
    {
        return isGrounded;
    }
}
