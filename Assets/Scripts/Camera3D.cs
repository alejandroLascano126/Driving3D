using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3D : MonoBehaviour
{
    public Transform targetPlayer;
    public GameObject Target = null;
    public GameObject  T = null;
    public float speed = 1.5f;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        T = GameObject.FindGameObjectWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(targetPlayer.position.x, targetPlayer.position.y + 10, targetPlayer.position.z - 20);
    }

    private void FixedUpdate()
    {
        this.transform.LookAt(Target.transform);
        float car_Move = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position));
        this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, car_Move * Time.deltaTime);
    }
}
