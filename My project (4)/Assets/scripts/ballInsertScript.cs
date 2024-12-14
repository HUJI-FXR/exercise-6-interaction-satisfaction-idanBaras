using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballInsertScript : MonoBehaviour
{
    [SerializeField] wallDisScript w;
    bool once;
    // Start is called before the first frame update
    void Start()
    {
        once = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (once)
        {
            if (other.gameObject.tag.Equals("ball")) {
                w.addOne();
                once = false;
            }
        }
    }

}
