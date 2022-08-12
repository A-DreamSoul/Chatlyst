﻿using System;
using UnityEngine;

namespace AVG.Runtime.Controller
{
    public class RuntimeBehavior : MonoBehaviour
    {
        public event Action OnStart;
        public event Action OnUpdate;
        public event Action OnDestroyed;

        private GameObject _behaviourGameObject;
        private RuntimeBehavior _runtimeBehavior;

        /// <summary>
        /// Initialize called when play
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            var rb = new GameObject("[RuntimeBehavior]");
            DontDestroyOnLoad(rb);
            var runtimeBehaviorComponent = rb.AddComponent<RuntimeBehavior>();
            runtimeBehaviorComponent._behaviourGameObject = rb;
            runtimeBehaviorComponent._runtimeBehavior = runtimeBehaviorComponent;

            //  new ViewManager().InitializeAsync(_runtimeBehavior).Start();
        }

        public GameObject GetRoot() => _behaviourGameObject;

        public void SetRootGameObject(GameObject child)
        {
            child.transform.SetParent(transform);
        }

        private void Start()
        {
            OnStart?.Invoke();
        }

        private void Update()
        {
            OnUpdate?.Invoke();
        }

        private void OnDestroy()
        {
            OnDestroyed?.Invoke();
        }
    }
}