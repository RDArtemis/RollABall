using UnityEngine;


public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereBody;
    [SerializeField] float ballSpeed;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereBody.AddForce(inputXZPlane * ballSpeed);
    }

    
   
}
