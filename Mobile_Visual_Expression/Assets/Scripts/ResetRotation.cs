using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{

    public Quaternion originalRotation;
    public GameObject character;
    public bool isCharacterDead;
    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.rotation;
              
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
