using UnityEngine;

public class projectilemovement2 : MonoBehaviour
{
    public projectilemovement2 projectilePrefab;
    public Vector2 velocity = new Vector2(-100, 0);

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }


    void Update()
    {

    }
}
