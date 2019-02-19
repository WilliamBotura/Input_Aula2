using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Inputs : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        //Pegar quantidades de toques na tela (max 10)
        //int quantidadeToques = Input.touchCount;
        //print(quantidadeToques);
        //Debug.Log(quantidadeToques);

        //exibir aceleração do dispositivo
        //var acceleration = Input.acceleration;
        //print(acceleration);

        //Exibir a position do toque
        //var position = Input.mousePosition;
        //print(position);

        //int quantidadeToques = Input.touchCount;

        //if (quantidadeToques > 0)
        //{
        //    for (int indexTouch = 0; indexTouch < quantidadeToques; indexTouch++)
        //    {
        //        var touch = Input.GetTouch(indexTouch);
        //        var positionTouch = touch.position;
        //        print(string.Format(
        //            "Touch: {0} - x: {1}, y: {2}",
        //            indexTouch,
        //            positionTouch.x,
        //            positionTouch.y
        //            ));
        //    }
        //}

        //Exibir posição de todos os touches usando forEach
        Touch[] touches = Input.touches;

        foreach (Touch touch in touches)
        {
            var positionTouch = touch.position;
            print(
                string.Format(
                "Touch: {0}  - TouchPhase: {3} - x: {1}, y: {2}",
                touch.fingerId,
                positionTouch.x,
                positionTouch.y,
                touch.phase
                ));
        }
    }
}