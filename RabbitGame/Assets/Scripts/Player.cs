using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public FixedJoystick joystick;
    public float speed;
    float hinput;
    float vinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hinput = joystick.Horizontal*speed*Time.deltaTime;
        vinput = joystick.Vertical*speed*Time.deltaTime;
        transform.Translate(hinput,vinput,0);
    }
}
