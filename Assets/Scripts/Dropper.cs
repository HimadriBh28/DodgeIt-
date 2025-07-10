using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float TimetoWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myGravity;


    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myGravity = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myGravity.useGravity = false;
        

    }

    void Update()
    {
        if (Time.time > TimetoWait)
        {
            Debug.Log("Lookout Below!");
            myMeshRenderer.enabled = true;
            myGravity.useGravity = true;
        }
        
    }
}
