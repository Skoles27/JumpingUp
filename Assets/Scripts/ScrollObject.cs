//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{

    public GameObject cubes;
    private Vector3 screenPoint, offset;
    private float _lockedYPos;

    void Update()
    {
        if (cubes.transform.position.x > 0)
            cubes.transform.position = Vector3.MoveTowards(cubes.transform.position, new Vector3(0f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 10f);
        else if (cubes.transform.position.x < -21f)
            cubes.transform.position = Vector3.MoveTowards(cubes.transform.position, new Vector3(-21f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 10f);
    }

    void OnMouseDown()
    {
        _lockedYPos = screenPoint.x;
        offset = cubes.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = _lockedYPos;
        cubes.transform.position = curPosition;
    }

    void OnMouseUp()
    {
        Cursor.visible = true;
    }
}
