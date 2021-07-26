using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timestamp;
    public float timeBetweenShots = 0.3333f;  // Saniyede 3 adet

    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        // On spacebar press, send dog
        if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + timeBetweenShots;

        }
    }
}
