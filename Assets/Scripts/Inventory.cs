using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public int BatteryCount = 0;
    public Texture2D[] meter_charge;
    public MeshRenderer meter_rend;
    public Sprite[] hudCharge;
    public Image hudCharge_GUI;

    void Awake()
    {
        instance = this;
    }

    private void CellPickUp()
    {
        BatteryCount++;
        meter_rend.material.mainTexture = meter_charge[BatteryCount - 1];
        hudCharge_GUI.sprite = hudCharge[BatteryCount - 1];
    }
}
