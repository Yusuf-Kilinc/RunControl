using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characther : MonoBehaviour
{

    public GameManager Manager;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * .5f * Time.deltaTime);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if(Input.GetAxis("Mouse X") < 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f, transform.position.y, transform.position.z), 3f);
            }
            if(Input.GetAxis("Mouse X") > 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f, transform.position.y, transform.position.z), 3f);
            }
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "X2" || other.name == "+3"|| other.name == "-4" || other.name == "/2")
            Manager.AdamYonetimi(other.name, other.transform);
        
    }


}
