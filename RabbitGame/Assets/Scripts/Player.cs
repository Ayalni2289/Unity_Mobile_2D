using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject winText;
    int socre=0;
    public FixedJoystick joystick;
    public float speed;
    float hinput;
    float vinput;
    public int winScore=5;
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
    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag== "Carrot"){
            socre++;
            Destroy(collision.gameObject) ;
            if(socre>=winScore){
                winText.SetActive(true);
            }
        }
    }
}
