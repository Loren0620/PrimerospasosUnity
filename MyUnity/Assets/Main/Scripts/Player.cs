using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Variables
 
   [SerializeField] private int edad = 19;
   private float velocidad = 15.5f;
   private string nombre = "Loren";
   private bool isJumping = false;

    Rigidbody2D rigidbody2D; 

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Mi edad es: " + edad);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UpDate");
    }
}
