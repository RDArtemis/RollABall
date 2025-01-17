using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; //initiallize vector2
        Vector3 inputXZ = new Vector3(inputVector.x, 0, inputVector.y);
        
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        Debug.Log("resultant vector = " + inputVector);
        Debug.Log("resultant 3Dvector = " + inputXZ);
    }
}
