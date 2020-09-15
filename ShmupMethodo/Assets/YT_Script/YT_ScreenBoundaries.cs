using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_ScreenBoundaries : MonoBehaviour
{
    public Camera mainCamera;
    private Vector2 screenbounds;
    private float objectWitdth;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
      screenbounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenbounds.x, screenbounds.x * -1);
        viewPos.y = Mathf.Clamp(viewPos.y, screenbounds.y, screenbounds.y * -1);
        transform.position = viewPos;
    }
}
