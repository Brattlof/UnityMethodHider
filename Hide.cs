using System;
using UnityEngine;

public class Base : MonoBehaviour
{

    public static GameObject handle;

    public static void Init()
    {
    }

    public void OnGui()
    {
    }

    public void Update()
    {
    }

}

public class Derived : Base
{

    public static void Init() // call in mono injector
    {
        handle = new GameObject();
        handle.AddComponent<Derived>();
        DontDestroyOnLoad(handle);
    }

    public void OnGui()
    {
        //Functions
    }

    public void Update()
    {
        //Functions
    }

}

class Final
{

  
    public static void Main()
    {
        
        Derived obj = new Derived();
        
        obj.OnGui();
        obj.Update();

    }
}
