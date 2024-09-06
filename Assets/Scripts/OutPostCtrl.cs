using UnityEngine;

public class OutPostCtrl : MonoBehaviour
{
    private OutPostDoorOpen doorOpen;
    private Animation ani;
    private bool isIdle = true;
    private int powerCell = 0;
    private const int maxPowerCell = 4;

    void Start()
    {
        ani = GetComponent<Animation>();
        doorOpen = transform.GetChild(8).GetComponent<OutPostDoorOpen>();
    }

    void Update()
    {
        DoorAnimation();
    }

    private void DoorAnimation()
    {
        if (powerCell >= maxPowerCell)
        {
            if (isIdle && doorOpen.isDoorOpen)
            {
                isIdle = false;
                ani.Play("dooropen");
            }
            else if (!isIdle && !doorOpen.isDoorOpen)
            {
                isIdle = true;
                ani.Play("doorshut");
            }
        }
    }

    public void AddPowerCell(int index) => powerCell += index;
}
