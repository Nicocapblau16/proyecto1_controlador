using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(x: 0, y: 5, z: -7);



    void LateUpdate()
    {
        //la camara copia el movimiento del "player" + el offset
        transform.position = player.transform.position + offset;
    }
}
