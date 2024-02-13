using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour

    
{

    [SerializeField] private GameObject camera;

    [SerializeField] private float speed = 12.5f;

    [SerializeField] private float lateralSpeed =  5f;

    [SerializeField] private float rotateSpeed = 75f;

    [SerializeField] private Vector3 offset = new Vector3(x: 0, y: 4, z:- 10);


    private float horitzontalinput;
    private float verticalinput;

    

    // Start is called before the first frame update
    void Start()
    {
       
        
    }
    // La deteccio de inputs ha d anar a s'uptadte
    // Hi ha Vector.(direccions) = right, left, up, down, forward i back
    // Es moviment es sempre en local, es a dir es mou segon la direccio del objecte
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        verticalinput = Input.GetAxis("Vertical");

        horitzontalinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horitzontalinput);

        camera.transform.position = transform.position + offset;

        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horitzontalinput);
        

    }
}
