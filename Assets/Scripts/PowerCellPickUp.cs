using UnityEngine;

public class PowerCellPickUp : MonoBehaviour
{
    private OutPostCtrl outPostCtrl;

    void Start()
    {
        outPostCtrl = FindFirstObjectByType<OutPostCtrl>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            outPostCtrl.AddPowerCell(1);
            col.SendMessage("CellPickUp", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
