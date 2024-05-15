using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float throwSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }
    void PlayerInput()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");
        float xOffset = xThrow * Time.deltaTime*throwSpeed;
        float yOffset = yThrow * Time.deltaTime*throwSpeed;
        float newXPos = transform.localPosition.z + xOffset;
        float newYPos = transform.localPosition.y + yOffset;
        if (newXPos >= 20f)
        {
            newXPos = 20f;
        }
        else if (newXPos <= -20f)
        {
            newXPos = -20f;
        }
        if (newYPos >= 19f)
        {
            newYPos = 19f;
        }
        else if (newYPos <= -3f)
        {
            newYPos = -3f;
        }


        transform.localPosition = new Vector3(transform.localPosition.x, newYPos, newXPos); // Axis Z calld as X because of some bug in unity Z and X are mixed out. IN script X is Z and Z is X.


    }
}
