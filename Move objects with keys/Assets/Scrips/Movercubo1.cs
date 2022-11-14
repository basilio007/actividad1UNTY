using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movercubo1 : MonoBehaviour
{
public Rigidbody cubo1;
public Rigidbody cubo2;
    public Rigidbody cubo3;
    public Rigidbody esfera1;
    public Rigidbody esfera2;

    void Update()
    {
       //movimientosd del cubo1
        if (Input.GetKey(KeyCode.Z))
        {
            cubo1.AddForce(0, 0, 30);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            cubo1.AddForce(0, 0, -30);
        }
       else if (Input.GetKey(KeyCode.A))
        {
            cubo1.AddForce(0, 30, 0);
        }
       /* else if (Input.GetKey(KeyCode.Space))
        {
            cubo1.AddForce(166, 59, -26);
        }
        */



        //movimientosd del cubo2
        if (Input.GetKey(KeyCode.X))
        {
            cubo2.AddForce(0, 0, 30);
        }
        if (Input.GetKey(KeyCode.W))
        {
            cubo2.AddForce(0, 0, -30);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubo2.AddForce(0, 30, 0);
        }

        //movimientosd del cubo3
        if (Input.GetKey(KeyCode.C))
        {
            cubo3.AddForce(0, 0, 30);
        }
        if (Input.GetKey(KeyCode.E))
        {
            cubo3.AddForce(0, 0, -30);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cubo3.AddForce(0, 30, 0);
        }

        //movimientosd del sfera1
        if (Input.GetKey(KeyCode.V))
        {
            esfera1.AddForce(0, 0, 30);
        }
        if (Input.GetKey(KeyCode.R))
        {
            esfera1.AddForce(0, 0, -30);
        }
        if (Input.GetKey(KeyCode.F))
        {
            esfera1.AddForce(0, 30, 0);
        }

        //movimientosd del sfera1
        if (Input.GetKey(KeyCode.B))
        {
            esfera2.AddForce(0, 0, 30);
        }
        if (Input.GetKey(KeyCode.T))
        {
            esfera2.AddForce(0, 0, -30);
        }
        if (Input.GetKey(KeyCode.G))
        {
            esfera2.AddForce(0, 30, 0);
        }
        
    }
}
