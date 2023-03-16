using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Rigidbody rb;
    public float sidewaysForce = 500f;
    private bool RightPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        RightPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        RightPressed = false;
    }
    private void Update()
    {
        if (RightPressed)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

}