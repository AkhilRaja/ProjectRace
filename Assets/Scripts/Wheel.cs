using UnityEngine;
using System.Collections;



[RequireComponent(typeof(WheelCollider))]
public class Wheel : MonoBehaviour {
    public WheelCollider wc;
    // Use this for initialization
    void Awake()
    {
        wc = GetComponent<WheelCollider>();
    }

    void Start () {
	
	}

    // Update is called once per frame
    public void Move(float value)
    {
        wc.motorTorque = value;
    }
    public void Turn(float value)
    {
        wc.steerAngle = value;
    }

}
