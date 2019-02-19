using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar_cubo : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float velocidade = 6.0f;
        var acceleration = Input.acceleration;
        transform.Translate(
            acceleration.x * Time.deltaTime * velocidade,
            0,
            -acceleration.z * Time.deltaTime * velocidade);
    }
}