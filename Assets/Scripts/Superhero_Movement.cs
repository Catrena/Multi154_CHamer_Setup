using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1, 0, 0);
    }
}
//public class is like a blueprint. objects are created from it. everything done is an object. start is called once. geme is made up of frames. things happening consitantl in the game goes
//in update