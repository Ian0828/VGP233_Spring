using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int maxDog = 1;
    private int currentDog;
    private float reloaTime = 1.5f;
    private bool isReloading = false;

    void Start()
    {
        currentDog = maxDog;
    }
    // Update is called once per frame
    void Update()
    {
        if (isReloading)
        {
            return;
        }

        if (currentDog <=0)
        {
            StartCoroutine(Reload());
            return;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Go();
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;

        yield return new WaitForSeconds(reloaTime);

        currentDog = maxDog;
        isReloading = false;
    }

    void Go()
    {
        currentDog--;
    }

    
}
