using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour {
    public enum Events {
        OnEquipmentChanged,
    }
    public static EventManager Instance { get; private set; }

    private Dictionary<Events, UnityEvent> simpleEventDictionary = new();


    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
            return;
        }
    }

    //========================
    public void Subscribe(Events eventName, UnityAction listener) {
        UnityEvent thisEvent = null;

        if (simpleEventDictionary.TryGetValue(eventName, out thisEvent)) {
            thisEvent.AddListener(listener);
        }
        else {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            simpleEventDictionary.Add(eventName, thisEvent);
        }
    }

    //========================
    public void Unsubscribe(Events eventName, UnityAction listener) {
        if (Instance == null)
            return;
        UnityEvent thisEvent = null;
        if (simpleEventDictionary.TryGetValue(eventName, out thisEvent)) {
            thisEvent.RemoveListener(listener);
        }
    }


    //========================
    public void Invoke(Events eventName) {
        UnityEvent thisEvent = null;
        if (simpleEventDictionary.TryGetValue(eventName, out thisEvent)) {
            thisEvent.Invoke();
        }
    }

}