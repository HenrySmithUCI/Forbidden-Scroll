using UnityEngine;
using System.Collections;

public class ClickAndDrag : MonoBehaviour {

    public SpringJoint2D ToControl;

    private Rigidbody2D selfBody;

    public void Start()
    {
        selfBody = GetComponent<Rigidbody2D>();
    }

    public void OnMouseDown()
    {
        ToControl.gameObject.SetActive(true);
        ToControl.connectedBody = selfBody;
        ToControl.connectedAnchor = transform.worldToLocalMatrix.MultiplyPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        selfBody.gravityScale = 1;
        selfBody.drag = 5;
        OnMouseDrag();
        
    }

    public void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        ToControl.transform.position = pos;
    }

    public void OnMouseUp()
    {
        selfBody.gravityScale = 0;
        selfBody.drag = 0;
        ToControl.gameObject.SetActive(false);
    }
}
