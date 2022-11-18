using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveSphere : MonoBehaviour
{
    private object transfrom;
    public int force = 10;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 2f;
    bool direction = true;
    [SerializeField]private float _MovementSpeed;

    void Start()
    {
        transform.position += new Vector3(0, 0, 20);


    }

    void Update()
    {
        //transform.position += Vector3.left * Time.deltaTime;
        transform.Translate(Vector3.left * Time.deltaTime * _MovementSpeed);
        if (transform.position.z < 47.96f && direction) // передвижение до определенных координат
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.09f);//задаем скорость движения по оси z
        else
        {
            direction = false; // если не истина, возвращяем объект в обратном направление
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.09f);
            if (transform.position.z < 18.62f) direction = true; // передвигаем до определенного координата

        }
        Debug.Log(transform.position);

    }
}
