using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputSeed : MonoBehaviour
{
    public static string input = "default";

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
