using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int velocidade = 50;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


            FindObjectOfType<gameMenage>().SubtrairMoedas(1);
            Destroy(gameObject);

        }

        void Update()
        {
            transform.Rotate(Vector3.forward * velocidade * Time.deltaTime);
        }
    }
}
