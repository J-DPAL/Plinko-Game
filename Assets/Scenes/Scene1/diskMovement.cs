using UnityEngine;

public class diskMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    private bool canMove = true;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        if (canMove)
        {
            float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            transform.position += new Vector3(move, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReleaseDisk();
        }
    }

    void ReleaseDisk()
    {
        canMove = false;
        rb.bodyType = RigidbodyType2D.Dynamic;

    }


    public void ResetMovement()
    {
        canMove = true; // Allow movement again
        rb.bodyType = RigidbodyType2D.Kinematic; // Reset physics
    }
}
