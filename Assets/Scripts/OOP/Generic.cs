using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generic script

public class AnyClass 
{
    public T GenericOperation<T>(T param)
    {
        return param;
    }
}

public class AnotherClass : MonoBehaviour 
{
    void Start () 
    {
        AnyClass anyInstance = new AnyClass();
        anyInstance.GenericOperation<int>(5);
    }
}

public class GenericEntity<T>
{
    T data;

    public void UpdateData(T newData)
    {
        data = newData;
    }
}

public class GenericEntityExample : MonoBehaviour 
{
    void Start () 
    {        
        GenericEntity<int> entity = new GenericEntity<int>();

        entity.UpdateData(5);
    }
}
