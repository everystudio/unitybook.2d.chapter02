using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RouletteController : MonoBehaviour
{
    private Rigidbody2D myRigidboyd;
    [SerializeField] private float currentAngle;
    [SerializeField] private TextMeshProUGUI weatherText;

    private void Start()
    {
        myRigidboyd = GetComponent<Rigidbody2D>();
        weatherText.text = "change text";
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            myRigidboyd.AddTorque(5f, ForceMode2D.Impulse);
            myRigidboyd.angularDrag = 0f;
            weatherText.color = Color.white;
        }
        if (Input.GetMouseButtonDown(1))
        {
            myRigidboyd.angularDrag = 0.75f;
        }

        if (myRigidboyd.IsSleeping())
        {
            weatherText.color = Color.red;
        }

        currentAngle = Vector3.SignedAngle(transform.up, Vector3.up, new Vector3(0f, 0f, -1f));
        currentAngle += 180f;

        if (currentAngle < 90f)
        {
            weatherText.text = "Moon";
        }
        else if (currentAngle < 180f)
        {
            weatherText.text = "Rain";
        }
        else if (currentAngle < 270f)
        {
            weatherText.text = "Fine";
        }
        else
        {
            weatherText.text = "Snow";
        }

    }
}
