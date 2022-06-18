
using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script is responsible to provide singleton pattern
/// </summary>
public abstract class MonoBehaviourSingleton<T> : MonoBehaviour
{
    private static Dictionary<Type, object> singletons = new Dictionary<Type, object>();
    public static T Instance
    {
        get
        {
            return (T)singletons[typeof(T)];
        }
    }

    private void Awake()
    {

        if (singletons.ContainsKey(GetType()))
        {
            Destroy(this.gameObject);
        }
        else
        {
            singletons.Add(GetType(), this.gameObject);
            DontDestroyOnLoad(this);
        }
    }
    
}
