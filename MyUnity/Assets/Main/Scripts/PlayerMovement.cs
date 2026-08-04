using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
 
    public float altura = 1.70f;
    public int edad = 19;
    public string nombre = "Loren";
    public bool puedeVotar = true;


    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;

    public Transform transform;
    private void Start()
    {
        Debug.Log("Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.white;
        transform.position = new Vector3(10, 0, 0);
    }
    
    private void update ()

    {

    }
}

