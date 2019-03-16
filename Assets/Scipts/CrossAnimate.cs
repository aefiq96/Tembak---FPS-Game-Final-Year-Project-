using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour
{
    GameObject UpCurs;
    GameObject DownCurs;
    GameObject LeftCurs;
    GameObject RightCurs;
    private Animator upAnim;
    private Animator downAnim;
    private Animator leftAnim;
    private Animator rightAnim;

    void Awake()
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
    {
        while (true)
        {
            while (!Input.GetButtonDown("Fire1"))
                yield return null;

            SetAnim(true);
            yield return new WaitForSeconds(0.1f);
            SetAnim(false);
        }
    }
}