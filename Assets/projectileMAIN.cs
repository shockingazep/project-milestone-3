using UnityEngine;

public class projectileMAIN : MonoBehaviour
{
    public GameObject prefabtospawn;

    public float secondspassed = 0f;
    public float spawnIntercalseconds = 1f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            secondspassed += Time.deltaTime;
            if (secondspassed >= spawnIntercalseconds)
            {
                Instantiate(prefabtospawn, transform.position, transform.rotation);
                secondspassed = 0f;

            }

        }
        else
        {
            secondspassed = 0f;
        }
    }
}
