using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public OpenDoor door;

    public int collectedItems = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collectedItems >= 3)
        {
            door.OpenTheDoor();
        }
        
    }


    void MyOwnMethod()
    {
        Debug.Log("method");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            Debug.Log("Name of GO: " + collision.gameObject.name);
            Destroy(collision.gameObject);

            collectedItems++;
        }
        
    }
}
