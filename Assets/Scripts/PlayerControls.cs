using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float throwSpeed = 50f;
    [SerializeField] float rollMultiplyer = 2f;
    [SerializeField] float pitchAngle = 30f;
    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }
    void PlayerInput()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");
        float xOffset = xThrow * Time.deltaTime * throwSpeed;
        float yOffset = yThrow * Time.deltaTime * throwSpeed;
        float yAngleOffset = yThrow * Time.deltaTime;
        float newXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -15f, 15f);
        float newYPos = Mathf.Clamp(transform.localPosition.y + yOffset, -2f, 14f);

        transform.localPosition = new Vector3(newXPos, newYPos, transform.localPosition.z);
        transform.localRotation = Quaternion.Euler(yAngleOffset * -pitchAngle, 0, newXPos * rollMultiplyer);
    }
}
