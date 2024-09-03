using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int velocidade = 50;


    private void OnTriggerEnter(Collider other)
    {
        if (orther.gameObject.tag == "Player")
        {


            {

                Destroy(GameObject);
            }
        }

        void Update()
        {
            transform.Rotate(Vector3.forward * velocidade * Time.deltaTime);
        }
    }
