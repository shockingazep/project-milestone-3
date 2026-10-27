using UnityEngine;

public class projectilemain3 : MonoBehaviour
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
        secondspassed += Time.deltaTime;
        if (secondspassed > 1f)
        {
            Instantiate(prefabtospawn, transform.position, Quaternion.identity);
            secondspassed = 0f;

        }

    }
}