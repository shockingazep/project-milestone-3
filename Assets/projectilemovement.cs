using UnityEngine;

public class projectilemovement : MonoBehaviour
{
    public projectilemovement projectilePrefab;
    public Vector2 velocity = new Vector2(0, 80);

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }

    
    void Update()
    {
        
    }
}
