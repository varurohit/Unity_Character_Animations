using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator demoAnim;
    // Start is called before the first frame update
    void Start()
    {
        demoAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        demoAnim.SetFloat("Ver", Input.GetAxis("Vertical"));
        demoAnim.SetFloat("Hor", Input.GetAxis("Horizontal"));
    }
}
