using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assistantController : MonoBehaviour
{
    Animator anim;
    public static assistantController instance;

    void Awake()
    {
        // (instance == null)
          //instance = this;
      //Debug.Log("this objectttt" + this);
    }

    // Start is called before the first frame update
    void Start()
    {

      //transform.gameObject.SetActive(true);
        anim = GameObject.Find("BlueSuitFree01").GetComponent<Animator>();

    }

    public void triggerAniamtion(string action)
    {
        anim.SetTrigger(action);
    }

    public void showMessage()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
