using UnityEngine;

public class Spinner : MonoBehaviour
{
    
    [SerializeField]float XrotationSpiny = 0.02f;
    [SerializeField]float YrotationSpiny = 0.02f;
    [SerializeField] float ZrotationSpiny = 0.02f;

    
    void Start()
    {
        
    }


    void Update()
    {
        
        transform.Rotate(XrotationSpiny,YrotationSpiny,ZrotationSpiny);
        
    }
}
