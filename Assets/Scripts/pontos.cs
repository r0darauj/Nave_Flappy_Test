using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontos : MonoBehaviour
{

    public gamecontroler controller;

    private void Start()
    {
        controller = FindObjectOfType<gamecontroler>();
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.score++;
        controller.scoretext.text = controller.score.ToString();
    }
}
