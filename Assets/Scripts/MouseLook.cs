using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 500f;

    public Transform playerBody;
    public float waitCursorLock = 1f;
    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CursorLock());
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator CursorLock()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        yield return new WaitForSeconds(waitCursorLock);
        Cursor.lockState = CursorLockMode.Locked;

        while(true)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
            yield return null;
        }
    }
}
