using UnityEngine;
using UnityEngine.Rendering;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] Transform player;
    Vector3 PlayerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void A()
    {
        PlayerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        shooters();


    }



    void DestroyWhenReached()
    {
        Destroy(gameObject);

    }

    void shooters()
    { 
        transform.position = Vector3.MoveTowards(transform.position, PlayerPosition, speed * Time.deltaTime);
        if (transform.position == PlayerPosition)
        {
            DestroyWhenReached();
        }
    }
}
