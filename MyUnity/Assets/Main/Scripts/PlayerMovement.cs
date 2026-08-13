using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables

    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private float _movementspeed = 5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundCheck _groundCheck;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()

    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
                Debug.Log("Oprimi la tecla");

      
            }
        }

       
        _rigidbody2D.velocity = Vector2.right * _movementspeed;
        
          
    }
}

