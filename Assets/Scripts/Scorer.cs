using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        { 
            hits = hits + 1;
            Debug.Log("You've bumped into this thing this many times: " + hits);
        }
        
    }
}
