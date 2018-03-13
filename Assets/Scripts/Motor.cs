using UnityEngine;
using System.Collections;



public class Motor : MonoBehaviour {
    public Wheel[] wheel;

    public float EnginePower;
    public float TurningPower;        
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void FixedUpdate()
    {

        float torque = Input.GetAxis("Vertical") * EnginePower;
        float Steer = Input.GetAxis("Horizontal") * TurningPower;

        wheel[0].Move(torque);
        wheel[1].Move(torque);

        wheel[0].Turn(Steer);
        wheel[1].Turn(Steer);

    }
}
