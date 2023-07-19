using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : Singleton<Crusher>
{
    [SerializeField]

    public bool canCrush;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hey..");
        if (other.CompareTag("Body"))
        {
            canCrush = true;
        }
        else
        {
            canCrush = false;
        }
            
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            canCrush = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            canCrush = false;
        }
    }


}
