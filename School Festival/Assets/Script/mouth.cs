using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouth : MonoBehaviour
{
    private Animator anim;
    public static mouth instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    public void Eatanim()
    {
        GetComponent<Animator>().SetTrigger("Eat");
    }
}
