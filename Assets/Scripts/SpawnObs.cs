using UnityEngine;
using UnityEngine.Rendering;

public class SpawnObs : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenspawn;
    private float spawntime;

    void spawn()
    {

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }


    void Update()
    {
        if (Time.time > spawntime)
        {
            spawn();
            spawntime = Time.time + timebetweenspawn;

        }
    }

}