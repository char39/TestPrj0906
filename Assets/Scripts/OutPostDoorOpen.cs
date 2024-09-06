using System.Collections;
using UnityEngine;

public class OutPostDoorOpen : MonoBehaviour
{
    public bool isDoorOpen = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
            StartCoroutine(DoorOpen());
    }

    private IEnumerator DoorOpen()
    {
        if (isDoorOpen) yield break;
        isDoorOpen = true;
        yield return new WaitForSeconds(3.0f);
        isDoorOpen = false;
    }
}
