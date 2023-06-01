using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newObjScripts : MonoBehaviour
{
    public bool height;
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
        if (other.gameObject.CompareTag("Player"))
        {
            if (height)
            {
                
                
                other.gameObject.GetComponent<Player>().AddHeight(-2);

                gameObject.GetComponent<BoxCollider>().isTrigger = false;
            }
            else
            {
                 
                other.gameObject.GetComponent<Player>().AddWidth(-1);

                gameObject.GetComponent<BoxCollider>().isTrigger = false;

            }

        }
    }
}
