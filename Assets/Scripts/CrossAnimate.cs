using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour
{   //declaring variables
    public GameObject UpCurs;
    public GameObject DownCurs;
    public GameObject LeftCurs;
    public GameObject RightCurs;
    public Animator upAnim;
    public Animator downAnim;
    public Animator leftAnim;
    public Animator rightAnim;

    /*void Awake()
    {
        StartCoroutine(WaitingAnim());
    }

    void SetAnim(bool aState)
    {
        upAnim.enabled = aState;
        downAnim.enabled = aState;
        leftAnim.enabled = aState;
        rightAnim.enabled = aState;
    }

    IEnumerator WaitingAnim()
    {   //while loop
        while (true)
        {
            while (!Input.GetButtonDown("Fire1"))
                yield return null;

            SetAnim(true);
            yield return new WaitForSeconds(0.1f);
            SetAnim(false);
        }
    }*/
    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                UpCurs.GetComponent("Animator");
                DownCurs.GetComponent("Animator");
                LeftCurs.GetComponent("Animator");
                RightCurs.GetComponent("Animator");
                WaitingAnim();
            }
        }
    }

    IEnumerator WaitingAnim()
    {
        yield return new WaitForSeconds(0.1f);
        UpCurs.GetComponent ( "Animator" );
        DownCurs.GetComponent ( "Animator" );
        LeftCurs.GetComponent ( "Animator" );
        RightCurs.GetComponent ( "Animator" );
    }
}