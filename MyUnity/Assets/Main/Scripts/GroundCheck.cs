using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour

{
public bool isGround;
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isGround)
        Debug.Log("Toco el suelo!!");
        isGround = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Me dejaron de tocar!!");
        isGround = false;
    }
}

