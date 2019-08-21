using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class example : MonoBehaviour
{
    [Range(0, 100)]
    public float Health;
    public GameObject P1HP;
    Animator P1BAR;
    // Start is called before the first frame update
    void Start()
    {
        P1BAR = P1HP.GetComponent<Animator>();
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        P1BAR.SetFloat("Health", Health);
    }
}
