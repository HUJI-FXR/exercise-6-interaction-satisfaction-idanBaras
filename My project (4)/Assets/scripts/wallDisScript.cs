using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDisScript : MonoBehaviour
{
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addOne() { 
        counter++;
        //Debug.Log(counter);
        if (counter >= 2) { 
            this.gameObject.SetActive(false);
        }
    }

}
