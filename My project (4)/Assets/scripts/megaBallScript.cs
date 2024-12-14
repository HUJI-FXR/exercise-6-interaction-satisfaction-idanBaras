using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaBallScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void throwing() {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 vec =new Vector3(this.transform.position.x - player.transform.position.x,
            this.transform.position.y - player.transform.position.y, this.transform.position.z - player.transform.position.z);
        Vector3 vec2 = vec.normalized;
        rb.AddForce(vec2*power, ForceMode.Impulse);
    }


}
