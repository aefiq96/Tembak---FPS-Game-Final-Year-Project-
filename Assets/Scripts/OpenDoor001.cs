using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor001 : MonoBehaviour
{
    // declaring variables
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject TheDoor;
    private Animator anim;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent< Text > ().text = "Press Button";
            if (Input.GetButtonDown("Action"))
            {
                Debug.Log("inside");

                if (TheDistance <= 2)
                {
                    StartCoroutine(OpenTheDoor(TheDoor));
                }
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent< Text > ().text = "";
    }

    /*IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }*/

    // Yield requires IEnumerator that's why we don't use void.
    IEnumerator OpenTheDoor(GameObject go)
    {
        // function that opens the door and stays open for 5 seconds then closes automatically
        go.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        go.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5);
        go.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        go.GetComponent<Animator>().enabled = false;
       
    }
}
