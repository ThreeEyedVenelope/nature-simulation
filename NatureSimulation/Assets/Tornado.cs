using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    [SerializeField]
    private float tornadoSpeed = 0;

    private Transform tornadoTransform = null;

    private void Awake()
    {
        tornadoTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        MoveTornado();
    }

    private void MoveTornado()
    {
        float tornadoPositionX = tornadoTransform.position.x;
        float tornadoPositionY = tornadoTransform.position.y;
        float tornadoPositionZ = tornadoTransform.position.z;

        tornadoPositionX += tornadoSpeed;
        tornadoPositionZ += tornadoSpeed;
        tornadoPositionX -= tornadoSpeed;
        tornadoPositionZ -= tornadoSpeed;


        tornadoTransform.position = new Vector3(tornadoPositionX, tornadoPositionY, tornadoPositionZ);
    }


}
