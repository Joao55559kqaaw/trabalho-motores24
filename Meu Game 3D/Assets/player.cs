using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class player : MonoBehaviour
{
    public int velocidade = 7;
    Rigidbody rb;

    public int forcaPulo = 7;
    public bool noChao = false;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
Debug.Log(message:"START");
        //alvo = GameObject.FindGameObjectWithTag("Player").transform;
        //offset = transform.position - alvo.positivo;
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chão")
        {
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "UPDATE");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space))
        {

    // pulo
            source.Play();
        
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            noChao = false;
        }
        

        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
     
}




