using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnbarreiras : MonoBehaviour
{
    public GameObject barreira;
    public float altura;
    public float tempoentre;
    private float timer = 0f;

    void Start()
    {
        GameObject novabarreira = Instantiate(barreira);
        novabarreira.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);

    }
    void Update()
    {
        if (timer > tempoentre)
        {
            GameObject novabarreira = Instantiate(barreira);
            novabarreira.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy (novabarreira, 10f);
            timer = 0;

        }
        timer += Time.deltaTime;
    }


}
