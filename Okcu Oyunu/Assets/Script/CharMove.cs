using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    [SerializeField] private float Speed,RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 30;
        RotationSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            this.gameObject.transform.Translate(Vector3.forward*Speed*Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {

            this.gameObject.transform.Translate(Vector3.back * Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {

            this.gameObject.transform.Rotate(0, -RotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            this.gameObject.transform.Rotate(0, RotationSpeed, 0);

        }
    }
}
