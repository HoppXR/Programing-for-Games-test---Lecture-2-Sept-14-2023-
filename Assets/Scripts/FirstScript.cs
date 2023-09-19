using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    /* The goal of this project is A,B,C
     * 
     * 
     * 
     * 
     */

    public int age = 20;
    float speed = 2.5f;
    // Camel case

    int NumberOfStudents = 0;
    int s = 100;

    char character = 'a';
    char cha = 'd';
    char ch = ' ';
    string str = " ";

    public string name = "Peter";
    string welcomeMessage = "Welcome!";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(welcomeMessage + " " + name);
        Debug.Log(age);
    }
    private void OnEnable()
    {
        Debug.Log("Inside OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("Inside OnDisable");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(age);
    }
}
