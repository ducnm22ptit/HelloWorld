using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        num += 1;
        //Debug.Log("Num: " + num);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    private void Count()
    {
        num += 2;
    }
}
