#region Libraries
using UnityEngine;
#endregion

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private bool doJump = false;
    private float movement;
    private BoxCollider2D boxCollider2D;
    private new Rigidbody2D rigidbody2D;
    [SerializeField] float jumpHeight = 2f;
    [SerializeField] float movementSpeed = 3f;
    #endregion

    #region Unity Methods
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CheckFloor())
            {
                doJump = true;
            }
        }
    }

    void FixedUpdate()
    {
        rigidbody2D.linearVelocityX = movement * movementSpeed;

        if (doJump)
        {
            Jump();
            doJump = false;
        }
    }
    #endregion

    #region Methods
    private bool CheckFloor()
    {
        float dy = (boxCollider2D.size.y * transform.localScale.y) / 2;
        float radius = 0.2f;
        float distance = 0.2f;
        Vector2 origin = new Vector2(transform.position.x, transform.position.y - dy);
        Vector2 direction = Vector2.down;
        LayerMask layerMask = LayerMask.GetMask("Ground");

        RaycastHit2D raycastHit2D = Physics2D.CircleCast(origin, radius, direction, distance, layerMask);

        return (raycastHit2D.collider != null);
    }
    private void Jump()
    {
        rigidbody2D.linearVelocityY = jumpHeight;
    }
    #endregion
}