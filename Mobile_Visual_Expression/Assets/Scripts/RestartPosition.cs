using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPosition : MonoBehaviour
{
    private Vector3 originalPos;
    public bool isDead;
    public GameObject world;
    private Quaternion ogRotation;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        isDead = false;
        ogRotation = world.GetComponent<ResetRotation>().originalRotation;
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Ground")
        {
            isDead = false;
           
        }
        if(collision.gameObject.tag == "Dead")
        {
            isDead = true;
            world.transform.rotation = Quaternion.Slerp(transform.rotation, ogRotation, Time.time * .5f);
            gameObject.transform.position = originalPos;
        }
              
        
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("You Won");
        }
    }

   
}
