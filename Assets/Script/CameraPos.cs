using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public GameObject player;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("X-bot");
    }
    
    // Update is called once per frame
    void Update()
    {
     transform.position = new Vector3(player.transform.position.x,player.transform.position.y + 2,player.transform.position.z- 5);   
    }
}
