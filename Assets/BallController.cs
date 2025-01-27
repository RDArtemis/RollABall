using UnityEngine;


public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereBody;
    [SerializeField] float ballSpeed;
    [SerializeField] float jumpForce = 5;
    [SerializeField] float groundCheckDistance = 1f;


    private bool isGrounded; //ball on ground?

    private void Update()
    {

        // Movement input (you can adapt this to your needs)
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        sphereBody.linearVelocity = new Vector3(movement.x * ballSpeed, sphereBody.linearVelocity.y, movement.z * ballSpeed);

        // Ground Check using Raycast
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        // Jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            sphereBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereBody.AddForce(inputXZPlane * ballSpeed);
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the ground (you might need to adjust this)
        if (collision.gameObject.CompareTag("Plane"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Check if the collision is with the ground (you might need to adjust this)
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }



}
