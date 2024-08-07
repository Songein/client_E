using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject original = Load<GameObject>($"Prefabs/{path}");
        if(original == null)
        {
            Debug.Log($"Failed to load prefab : {path}");
            return null;
        }

        GameObject obj = Object.Instantiate(original, parent);
        obj.name = original.name;

        return obj;
    }
    
    public GameObject Instantiate(GameObject go, Vector3 vec)
    {
        return Object.Instantiate(go, vec, Quaternion.identity);
    }
    
    public GameObject Instantiate(GameObject go)
    {
        return Object.Instantiate(go);
    }
        
    public GameObject Instantiate(GameObject go, Transform parent)
    {
        return Object.Instantiate(go, parent);
    }

    public void Destroy(GameObject _go, float _time = 0.0f) {
        if (_go == null)
        {
            Debug.Log($"Object you want to Destroy is Null : {_go}");
            return;
        }
        Object.Destroy(_go, _time);
    }
}
