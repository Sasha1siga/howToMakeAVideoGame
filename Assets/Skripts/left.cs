using UnityEngine;
using UnityEngine.EventSystems;

public class left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Rigidbody rb;
    public float sidewaysForce = 500f;
    private bool leftPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        leftPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        leftPressed = false;
    }
    private void Update()
    {
        if (leftPressed)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

}