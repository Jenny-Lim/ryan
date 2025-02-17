using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    [SerializeField]
    private int test;

    [SerializeField]
    private GameObject cube;

    int i = 0; // test variable for update 

    // function that adds two integers to return the result as an integer
    int add(int a, int b)
    {
        return a + b;
    }

    // Start is called before the first frame update
    void Start()
    {
        int i = 0; // type of number

        // decimals
        float f = 0.5f;
        double d = 0.5;

        // characters and strings
        char c = '!';
        string s = "aokldjsakljdhjasjkl!"; // a string is a list of characters

        char[] chars = new char[10]; // list of 10 characters
        chars[0] = 'a';

        char[] chars1 = { 'a', 'b', 'c' }; // list of 3 characters

        // for loop
        //for (int j = 0; j <= chars1.Length; j++)
        //{
        //Debug.Log(chars1[j]);
        //}

        // while loop
        //int j = 0;
        //while(j < chars1.Length)
        //{
        //    Debug.Log(chars1[j]);
        //    j++;
        //}

        // for each loop
        //foreach (char character in chars1)
        //{
        //print(character); // print is the same thing as Debug.Log
        //}

        //Debug.Log(test); // testing serializefield

        // program goes down this list in order. one result
        //if (test % 2 == 0)
        //{
        //    Debug.Log("even");
        //}
        //else if (test >= 21)
        //{
        //    Debug.Log("test is 21");
        //}
        //else
        //{
        //    Debug.Log("odd or not 21");
        //}

        //switch (test) // cant use [ > < == ] stuff
        //{
        //    case 20:
        //        Debug.Log("test is 20");
        //        break;

        //    case 21:
        //        Debug.Log("test is 21");
        //        break;

        //    default: // basically an else in a switch
        //        Debug.Log("somethuinge else");
        //        break;
        //}

        
        Debug.Log(gameObject.name); // type gameObject if you want the object the component is attached to


        Debug.Log(cube.transform.position);

        print( "add result: " + add(4, 3) ); // concatenate
    }

    //void FixedUpdate()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        //if (i < 20)
        //{
        //    i++;
        //    print(i);
        //}
    //}
}
