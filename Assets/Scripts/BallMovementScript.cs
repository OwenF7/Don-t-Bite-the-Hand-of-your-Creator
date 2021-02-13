using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    // Your target. (taken from your code)
    public GameObject Ball;
    public GameObject cameraObject;

    public float m_powerMin = 1f;               // Lowest amount of power to fire with.
    public float m_powerMax = 5f;              // Highest amount of power to fire with.
    public float m_chargeDurationMax = 2f;      // Time at which auto-fire happens.
    private float m_chargeDurationCurrent = 0f; // Time spent holding left mouse button down.
    private bool m_isCharging = false;          // Currently charging?
    private bool m_mouseWasReleased = true;

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && m_mouseWasReleased)
        {
            // Started Charging
            m_chargeDurationCurrent = 0f;
            m_isCharging = true;
            m_mouseWasReleased = false;
        }
        else if (m_isCharging && (Input.GetMouseButtonUp(0) || m_chargeDurationCurrent >= m_chargeDurationMax))
        {
            // Release or Auto-release.
            float power = Mathf.Lerp(m_powerMin, m_powerMax, m_chargeDurationCurrent / m_chargeDurationMax);

            // Your method.
            Fire(power);
            Reset();
        }

        // Currently Charging.
        if (m_isCharging)
        {
            m_chargeDurationCurrent += Time.deltaTime;
        }

        // Only after you release the mouse button, we will allow the next shot.
        // If the shot was called via hitting the charge duration max, this will prevent from infinitely firing every X duration.
        if (!m_mouseWasReleased)
        {
            m_mouseWasReleased = Input.GetMouseButtonUp(0);
        }
    }

    private void Fire(float power)
    {
        // Apply Force to your ball ;-)
        Debug.Log("Test: " + power);
        if (Ball != null)
        {
            Ball.GetComponent<Rigidbody>().AddForce(cameraObject.transform.forward * power, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Ball reference was null, please go to the inspector of the object: " + this.name + " and drag in any target gameObject with a rigidbody to fix this.");
        }
    }

    private void Reset()
    {
        // Reset Current Duration.
        m_chargeDurationCurrent = 0f;
        m_isCharging = false;
    }

}
