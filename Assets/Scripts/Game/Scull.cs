using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scull : MonoBehaviour
{
   [SerializeField] private Transform endPos;
   [SerializeField] private Timer timer;

   private  Vector3 startPos;

   private void Awake()
   {
      startPos = transform.position;
   }

   private void FixedUpdate()
   {
      transform.position = Vector3.Lerp(startPos, endPos.position, timer.CurrentTime / 30);
   }
}
