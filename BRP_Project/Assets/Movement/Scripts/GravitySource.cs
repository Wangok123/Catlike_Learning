using System.Collections.Generic;
using UnityEngine;

namespace Movement.Scripts
{
    public class GravitySource : MonoBehaviour {
        
        void OnEnable () {
            CustomGravity.Register(this);
        }

        void OnDisable () {
            CustomGravity.Unregister(this);
        }
        
        public virtual Vector3 GetGravity (Vector3 position) {
            return Physics.gravity;
        }
    }
}