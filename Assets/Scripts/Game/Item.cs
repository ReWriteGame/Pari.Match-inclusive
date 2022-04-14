using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public UnityEvent getDestroyerEvent;
    public UnityEvent getPlayerEvent;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<Destroyable>())
            getDestroyerEvent?.Invoke();
        
        if(col.gameObject.GetComponent<Player>())
            getPlayerEvent?.Invoke();
    }
}
