using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabtospawn;
    public float secondspassed = 0f;
    public float spawnIntercalseconds = 1f;
    public bool isSpawning = true;
    void Start()
    {

    }


    void Update()
    {
        secondspassed += Time.deltaTime;
        if (secondspassed > spawnIntercalseconds && isSpawning)
        {
            Instantiate(prefabtospawn, transform.position, Quaternion.identity);
            secondspassed = 0f;
        }
    }
}