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
        myRigidboyd.AddTorque(5f, ForceMode2D.Impulse);
        weatherText.text = "文字を変更";
    }
    void Update()
    {
        currentAngle = Vector3.SignedAngle(transform.up, Vector3.up, new Vector3(0f, 0f, -1f));
    }
}
