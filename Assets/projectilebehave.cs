using UnityEngine;

public class projectilebehaviour : MonoBehaviour
{
    public float speed = 4.5f;
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
