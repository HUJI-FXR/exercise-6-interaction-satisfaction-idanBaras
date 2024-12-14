using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallenBookScript : MonoBehaviour
{
    [SerializeField] GameObject fallenBook;
    [SerializeField] float power;
    bool once = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("theBook")) {
            if (once)
            {
                Rigidbody rb = fallenBook.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(power, 0, 0), ForceMode.Impulse);
                once = false;
            }
        }
    }
}
