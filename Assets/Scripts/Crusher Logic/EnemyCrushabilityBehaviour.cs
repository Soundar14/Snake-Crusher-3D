using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class EnemyCrushabilityBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Body") && Crusher.Instance.canCrush)
        {
            Debug.LogWarning(other.ToString());
            Destroy(this.gameObject);
        }

        
    }
}
