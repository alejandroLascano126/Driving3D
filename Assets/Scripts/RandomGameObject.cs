using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomGameObject : MonoBehaviour
{
    public GameObject[] itemPrefab;
    public Transform tarjetPlayer;

    public float minTime = 0f;
    public float maxTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(tarjetPlayer.position.x, tarjetPlayer.position.y + 10, tarjetPlayer.position.y + 20);
        StartCoroutine(SpawnCoRutine(0));
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }

    IEnumerator SpawnCoRutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        //transform.position

        Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)],new Vector3(transform.position.x + Random.Range(1,10), transform.position.y + Random.Range(1, 10), transform.position.z + Random.Range(1, 10)), Quaternion.identity);

        StartCoroutine(SpawnCoRutine(Random.Range(minTime, maxTime)));
    }
}
