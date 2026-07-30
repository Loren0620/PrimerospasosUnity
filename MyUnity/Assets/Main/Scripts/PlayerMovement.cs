using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    //Variables
    [SerializeField] private int _edad = 19;
    private float _velocidad = 15.5f;
    private string nombre = "Loren";
    private bool isJumping = false;

    public float fuerza = 500f;

    [SerializeField] private Rigidbody2D _rigidbody2;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2.AddForce(Vector2.right * fuerza);
        Debug.Log("Mi edad es: " + _edad);
    }   


    // Update is called once per frame
    void Update()
    {
        Debug.Log("UpDate");
    }
}
