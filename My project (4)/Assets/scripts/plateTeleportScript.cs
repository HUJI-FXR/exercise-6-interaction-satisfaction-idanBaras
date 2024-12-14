using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateTeleportScript : MonoBehaviour
{
    [SerializeField] GameObject placeToTeleport;
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
        if (other.gameObject.tag.Equals("playerVR")) { 
            Transform t = other.GetComponent<Transform>();
            t.position =new Vector3(placeToTeleport.transform.position.x, placeToTeleport.transform.position.y + 1, placeToTeleport.transform.position.z);
        }
    }

}
