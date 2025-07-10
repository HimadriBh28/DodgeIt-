using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();


    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
    }

    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yVal = 0f;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, yVal, zVal);
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use wasd for movement");
        Debug.Log("Don't bump into the objects");
    }
}
